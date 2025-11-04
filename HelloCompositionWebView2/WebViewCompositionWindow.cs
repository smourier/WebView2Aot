using System.Runtime.InteropServices.Marshalling;

namespace HelloCompositionWebView2;

[GeneratedComClass]
public partial class WebViewCompositionWindow : CompositionWindow, IDropTarget
{
    private ComObject<ICoreWebView2CompositionController>? _controller;
    private IComObject<ICoreWebView2CompositionController3>? _controller3;
    private ComObject<ICoreWebView2_3>? _webView;
    private readonly bool[] _capturedButtons = new bool[Enum.GetNames<MouseButton>().Length];
    private bool _mouseTracking;
    private bool _isDropTarget;
    private WebView2.EventRegistrationToken _cursorChangedToken;

    public WebViewCompositionWindow(string? title = null)
        : base(title)
    {
        WebView2.Functions.CreateCoreWebView2EnvironmentWithOptions(PWSTR.Null, PWSTR.Null, null!,
            new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler((result, envObj) =>
            {
                var env3 = (ICoreWebView2Environment3)envObj;
                using var env = new ComObject<ICoreWebView2Environment3>(env3);
                env3.CreateCoreWebView2CompositionController(Handle, new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler((result, controller) =>
                {
                    _controller = new ComObject<ICoreWebView2CompositionController>(controller);
                    _controller3 = ComExtensions.As<ICoreWebView2CompositionController3>(_controller);
                    _controller.Object.add_CursorChanged(new CoreWebView2CursorChangedEventHandler((sender, args) =>
                    {
                        var cursor = new HCURSOR();
                        if (sender.get_Cursor(ref cursor).IsSuccess)
                        {
                            DirectN.Functions.SetClassLongPtrW(Handle, GET_CLASS_LONG_INDEX.GCLP_HCURSOR, cursor.Value);
                        }

                    }), ref _cursorChangedToken);

                    var cb = RootVisual.As<IUnknown>();
                    _controller.Object.put_RootVisualTarget(cb).ThrowOnError();

                    var ctrl = (ICoreWebView2Controller)controller;
                    ctrl.put_Bounds(ClientRect).ThrowOnError();
                    ctrl.get_CoreWebView2(out var webView2).ThrowOnError();
                    _webView = new ComObject<ICoreWebView2_3>(webView2);

                    ControllerCreated();

                    // use 1st arg from command line or default to Bing
                    var url = CommandLine.Current.GetNullifiedArgument(0, "https://www.bing.com/");
                    webView2.Navigate(PWSTR.From(url));
                    OnFocusChanged(true);
                }));
            }));
    }

    protected ComObject<ICoreWebView2CompositionController>? Controller => _controller;
    protected ComObject<ICoreWebView2_3>? WebView => _webView;

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
            _controller?.As<ICoreWebView2Controller>()?.Object.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON.COREWEBVIEW2_MOVE_FOCUS_REASON_PROGRAMMATIC);
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

                _controller?.Object.SendMouseInput(
                    COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_MOVE,
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(),
                    0,
                    lParam.ToPOINT()).ThrowOnError();
                break;

            case MessageDecoder.WM_MOUSELEAVE:
                _mouseTracking = false;
                _controller?.Object.SendMouseInput(
                    COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_LEAVE,
                    COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_NONE,
                    0,
                    POINT.Zero).ThrowOnError();
                return 0;

            case MessageDecoder.WM_LBUTTONDOWN:
            case MessageDecoder.WM_RBUTTONDOWN:
            case MessageDecoder.WM_MBUTTONDOWN:
            case MessageDecoder.WM_XBUTTONDOWN:
                button = Extensions.MessageToButton(msg, wParam);
                _capturedButtons[(int)button] = true;
                DirectN.Functions.SetCapture(hwnd);

                _controller?.Object.SendMouseInput(
                    button.GetKind(ButtonAction.Down),
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(button),
                    button == MouseButton.X1 ? 1u : button == MouseButton.X2 ? 2u : 0,
                    lParam.ToPOINT()).ThrowOnError();
                break;

            case MessageDecoder.WM_LBUTTONUP:
            case MessageDecoder.WM_RBUTTONUP:
            case MessageDecoder.WM_MBUTTONUP:
            case MessageDecoder.WM_XBUTTONUP:
                button = Extensions.MessageToButton(msg, wParam);
                _capturedButtons[(int)button] = false;
                DirectN.Functions.ReleaseCapture();

                _controller?.Object.SendMouseInput(
                    button.GetKind(ButtonAction.Up),
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(button),
                    button == MouseButton.X1 ? 1u : button == MouseButton.X2 ? 2u : 0,
                    lParam.ToPOINT()).ThrowOnError();
                break;

            case MessageDecoder.WM_LBUTTONDBLCLK:
            case MessageDecoder.WM_RBUTTONDBLCLK:
            case MessageDecoder.WM_MBUTTONDBLCLK:
            case MessageDecoder.WM_XBUTTONDBLCLK:
                button = Extensions.MessageToButton(msg, wParam);
                _capturedButtons[(int)button] = false;
                DirectN.Functions.SetCapture(hwnd);

                _controller?.Object.SendMouseInput(
                    button.GetKind(ButtonAction.DoubleClick),
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(button),
                    button == MouseButton.X1 ? 1u : button == MouseButton.X2 ? 2u : 0,
                    lParam.ToPOINT()).ThrowOnError();
                break;

            case MessageDecoder.WM_MOUSEHWHEEL:
            case MessageDecoder.WM_MOUSEWHEEL:
                _controller?.Object.SendMouseInput(
                    msg == MessageDecoder.WM_MOUSEHWHEEL
                    ? COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_HORIZONTAL_WHEEL
                    : COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_WHEEL,
                    ((MODIFIERKEYS_FLAGS)wParam.Value.LOWORD()).GetKeys(null),
                    (uint)wParam.Value.SignedHIWORD(),
                    lParam.ToPOINT().ScreenToClient(hwnd)).ThrowOnError();
                break;
        }
        return base.WindowProc(hwnd, msg, wParam, lParam);
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        if (_controller?.Object is ICoreWebView2Controller c)
        {
            c.put_Bounds(ClientRect).ThrowOnError();
        }
        return base.OnResized(type, size);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_cursorChangedToken.value != 0)
            {
                _controller?.Object.remove_CursorChanged(_cursorChangedToken);
                _cursorChangedToken.value = 0;
            }
            _controller?.Dispose();
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
