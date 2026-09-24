using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

namespace HelloCompositionWebView2;

[GeneratedComClass]
public partial class WebViewCompositionWindow : CompositionWindow, IDropTarget
{
    private readonly bool[] _capturedButtons = new bool[Enum.GetNames<MouseButton>().Length];
    private readonly HashSet<uint> _pointerIdsStartingInWebView = [];
    private IComObject<ICoreWebView2CompositionController>? _controller;
    private IComObject<ICoreWebView2CompositionController3>? _controller3;
    private IComObject<ICoreWebView2Controller>? _coreController;
    private IComObject<ICoreWebView2>? _webView;
    private bool _mouseTracking;
    private bool _isDropTarget;
    private CoreWebView2CompositionControllerEvents? _controllerEvents;

    public WebViewCompositionWindow(string? title = null)
        : base(title)
    {
        // this checks WebView2Loader.dll is present somewhere (file path or embedded resource)
        WebView2Utilities.Initialize(Assembly.GetEntryAssembly());

        // this checks WebView2 itself is installed
        var browserVersion = WebView2Utilities.GetAvailableCoreWebView2BrowserVersionString();
        if (browserVersion != null)
        {
            Text = $"{Text} - WebView2 V{browserVersion}";
        }
        else
        {
            Text = $"{Text} - WebView2 was not found";
        }

        InitializeWebView();
    }

    private async void InitializeWebView()
    {
        using var env = await WebView2.Functions.CreateCoreWebView2EnvironmentWithOptionsAsync(null, WebView2Utilities.GetDefaultUserDataFolder(), null) ?? throw new InvalidOperationException();
        _controller = await env.CreateCoreWebView2CompositionControllerAsync(Handle) ?? throw new InvalidOperationException();
        _controller3 = ComExtensions.As<ICoreWebView2CompositionController3>(_controller);
        _controllerEvents = new CoreWebView2CompositionControllerEvents(_controller);
        _controllerEvents.CursorChanged += (sender, e) =>
        {
            if (sender is ICoreWebView2CompositionController c)
            {
                DirectN.Functions.SetClassLongPtrW(Handle, GET_CLASS_LONG_INDEX.GCLP_HCURSOR, c.Cursor.Value);
            }
        };

        _controller.RootVisualTarget = RootVisual;

        _coreController = _controller.As<ICoreWebView2Controller>() ?? throw new InvalidOperationException();
        _coreController.Bounds = ClientRect;
        _webView = _coreController.CoreWebView2 ?? throw new InvalidOperationException();

        ControllerCreated();

        // use 1st arg from command line or default to Bing
        var url = CommandLine.Current.GetNullifiedArgument(0, "https://www.bing.com/");
        _webView.Navigate(url);
        OnFocusChanged(true);
    }

    protected IComObject<ICoreWebView2CompositionController>? Controller => _controller;
    protected IComObject<ICoreWebView2>? WebView => _webView;

    protected virtual RECT? GetCaptionRect() => null;
    protected virtual void ControllerCreated()
    {
    }

    public bool IsDropTarget
    {
        get => _isDropTarget;
        set
        {
            if (value == _isDropTarget)
                return;

            if (value)
            {
                // we need to ensure this as STAThread doesn't always call it for some reason
                DirectN.Functions.OleInitialize(0); // don't check error
                var hr = DirectN.Functions.RegisterDragDrop(Handle, this);
                if (hr.IsError && hr != DirectN.Constants.DRAGDROP_E_ALREADYREGISTERED)
                    throw new Exception("Cannot enable drag & drop operations. Make sure the thread is initialized as an STA thread.", Marshal.GetExceptionForHR((int)hr)!);

                _isDropTarget = true;
            }
            else
            {
                var hr = DirectN.Functions.RevokeDragDrop(Handle);
                hr.ThrowOnErrorExcept(DirectN.Constants.DRAGDROP_E_NOTREGISTERED);
                _isDropTarget = false;
            }
        }
    }

    protected override bool OnFocusChanged(bool setOrKill)
    {
        if (setOrKill)
        {
            _coreController?.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON.COREWEBVIEW2_MOVE_FOCUS_REASON_PROGRAMMATIC);
            return true;
        }
        return base.OnFocusChanged(setOrKill);
    }

    protected override LRESULT? WindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        MouseButton button;
        switch (msg)
        {
            case MessageDecoder.WM_MOUSEMOVE:
                if (!_mouseTracking)
                {
                    unsafe
                    {
                        // https://learn.microsoft.com/en-us/windows/win32/learnwin32/other-mouse-operations#mouse-tracking-events-hover-and-leave
                        var tme = new TRACKMOUSEEVENT
                        {
                            cbSize = (uint)sizeof(TRACKMOUSEEVENT),
                            dwFlags = TRACKMOUSEEVENT_FLAGS.TME_LEAVE | TRACKMOUSEEVENT_FLAGS.TME_HOVER,
                            hwndTrack = hwnd,
                        };
                        _mouseTracking = DirectN.Functions.TrackMouseEvent(ref tme);
                    }
                }

                _controller?.SendMouseInput(
                    COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_MOVE,
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(),
                    0,
                    lParam.ToPOINT());
                break;

            case MessageDecoder.WM_MOUSELEAVE:
                _mouseTracking = false;
                _controller?.SendMouseInput(
                    COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_LEAVE,
                    COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_NONE,
                    0,
                    POINT.Zero);
                return 0;

            case MessageDecoder.WM_LBUTTONDOWN:
            case MessageDecoder.WM_RBUTTONDOWN:
            case MessageDecoder.WM_MBUTTONDOWN:
            case MessageDecoder.WM_XBUTTONDOWN:
                button = Extensions.MessageToButton(msg, wParam);
                _capturedButtons[(int)button] = true;
                DirectN.Functions.SetCapture(hwnd);

                _controller?.SendMouseInput(
                    button.GetKind(ButtonAction.Down),
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(button),
                    button == MouseButton.X1 ? 1u : button == MouseButton.X2 ? 2u : 0,
                    lParam.ToPOINT());
                break;

            case MessageDecoder.WM_LBUTTONUP:
            case MessageDecoder.WM_RBUTTONUP:
            case MessageDecoder.WM_MBUTTONUP:
            case MessageDecoder.WM_XBUTTONUP:
                button = Extensions.MessageToButton(msg, wParam);
                _capturedButtons[(int)button] = false;
                DirectN.Functions.ReleaseCapture();

                _controller?.SendMouseInput(
                    button.GetKind(ButtonAction.Up),
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(button),
                    button == MouseButton.X1 ? 1u : button == MouseButton.X2 ? 2u : 0,
                    lParam.ToPOINT());
                break;

            case MessageDecoder.WM_LBUTTONDBLCLK:
            case MessageDecoder.WM_RBUTTONDBLCLK:
            case MessageDecoder.WM_MBUTTONDBLCLK:
            case MessageDecoder.WM_XBUTTONDBLCLK:
                button = Extensions.MessageToButton(msg, wParam);
                _capturedButtons[(int)button] = false;
                DirectN.Functions.SetCapture(hwnd);

                _controller?.SendMouseInput(
                    button.GetKind(ButtonAction.DoubleClick),
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(button),
                    button == MouseButton.X1 ? 1u : button == MouseButton.X2 ? 2u : 0,
                    lParam.ToPOINT());
                break;

            case MessageDecoder.WM_MOUSEHWHEEL:
            case MessageDecoder.WM_MOUSEWHEEL:
                _controller?.SendMouseInput(
                    msg == MessageDecoder.WM_MOUSEHWHEEL
                    ? COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_HORIZONTAL_WHEEL
                    : COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_WHEEL,
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(null),
                    (uint)wParam.Value.SignedHIWORD(),
                    lParam.ToPOINT().ScreenToClient(hwnd));
                break;

            case MessageDecoder.WM_POINTERACTIVATE:
            case MessageDecoder.WM_POINTERDOWN:
            case MessageDecoder.WM_POINTERENTER:
            case MessageDecoder.WM_POINTERLEAVE:
            case MessageDecoder.WM_POINTERUP:
            case MessageDecoder.WM_POINTERUPDATE:
                if (TryForwardPointerInput(msg, wParam, lParam))
                    return 0;

                break;
        }
        return base.WindowProc(hwnd, msg, wParam, lParam);
    }

    // from https://github.com/MicrosoftEdge/WebView2Samples/blob/main/SampleApps/WebView2APISample/ViewComponent.cpp
    protected virtual bool TryForwardPointerInput(uint msg, WPARAM wParam, LPARAM lParam)
    {
        if (Controller == null)
            return false;

        var pointerId = wParam.GetPointerId();
        var point = lParam.ToPOINT().ScreenToClient(Handle);
        var pointerStartedInWebView = _pointerIdsStartingInWebView.Contains(pointerId);
        if (!pointerStartedInWebView && !ClientRect.Contains(point))
            return false;

        if (!pointerStartedInWebView && (msg == MessageDecoder.WM_POINTERENTER || msg == MessageDecoder.WM_POINTERDOWN))
        {
            _pointerIdsStartingInWebView.Add(pointerId);
        }
        else if (msg == MessageDecoder.WM_POINTERLEAVE)
        {
            _pointerIdsStartingInWebView.Remove(pointerId);
        }

        if (Controller.Object is not ICoreWebView2ExperimentalCompositionController4)
            return false;

        var matrix = D2D_MATRIX_4X4_F.Identity();
        // this is needed to adjust pointer coordinates from screen to webview's root visual target, which may be different if the window is moved, etc.
        //matrix._41 += webViewBounds left
        //matrix._42 += m_webViewBounds top
        using var info = Controller.CreateCoreWebView2PointerInfoFromPointerId(pointerId, Handle, matrix);
        if (info == null)
            return false;

        Controller.SendPointerInput((COREWEBVIEW2_POINTER_EVENT_KIND)msg, info);
        return true;
    }

    protected override bool OnMoving(ref RECT rc)
    {
        _coreController?.NotifyParentWindowPositionChanged();
        return base.OnMoving(ref rc);
    }

    protected override bool OnMoved()
    {
        _coreController?.NotifyParentWindowPositionChanged();
        return base.OnMoved();
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        _coreController?.Bounds = ClientRect;
        return base.OnResized(type, size);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Interlocked.Exchange(ref _controllerEvents, null)?.Dispose();
            _coreController = null;
            var controller = Interlocked.Exchange(ref _controller, null);
            if (controller?.Object is ICoreWebView2Controller coreController)
            {
                coreController.Close();
            }

            controller?.Dispose();
        }
        base.Dispose(disposing);
    }

    HRESULT IDropTarget.DragEnter(IDataObject pDataObj, MODIFIERKEYS_FLAGS grfKeyState, POINTL pt, ref DROPEFFECT pdwEffect)
    {
        if (_controller3 == null)
            return DirectN.Constants.E_NOTIMPL;

        var effect = (uint)pdwEffect;
        var hr = _controller3.Object.DragEnter(pDataObj, (uint)grfKeyState, ScreenToClient(new POINT(pt.x, pt.y)), ref effect);
        if (hr.IsSuccess)
        {
            pdwEffect = (DROPEFFECT)effect;
        }
        return hr;
    }

    HRESULT IDropTarget.DragOver(MODIFIERKEYS_FLAGS grfKeyState, POINTL pt, ref DROPEFFECT pdwEffect)
    {
        if (_controller3 == null)
            return DirectN.Constants.E_NOTIMPL;

        var effect = (uint)pdwEffect;
        var hr = _controller3.Object.DragOver((uint)grfKeyState, ScreenToClient(new POINT(pt.x, pt.y)), ref effect);
        if (hr.IsSuccess)
        {
            pdwEffect = (DROPEFFECT)effect;
        }
        return hr;
    }

    HRESULT IDropTarget.DragLeave()
    {
        if (_controller3 == null)
            return DirectN.Constants.E_NOTIMPL;

        return _controller3.Object.DragLeave();
    }

    HRESULT IDropTarget.Drop(IDataObject pDataObj, MODIFIERKEYS_FLAGS grfKeyState, POINTL pt, ref DROPEFFECT pdwEffect)
    {
        if (_controller3 == null)
            return DirectN.Constants.E_NOTIMPL;

        var effect = (uint)pdwEffect;
        var hr = _controller3.Object.Drop(pDataObj, (uint)grfKeyState, ScreenToClient(new POINT(pt.x, pt.y)), ref effect);
        if (hr.IsSuccess)
        {
            pdwEffect = (DROPEFFECT)effect;
        }
        return hr;
    }
}
