namespace WebView2.Utilities;

public sealed class CoreWebView2ControllerEvents(ICoreWebView2Controller instance) : IDisposable
{
    private readonly ICoreWebView2Controller _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _zoomFactorChanged;
    private EventRegistrationToken _zoomFactorChangedToken;
    private EventHandler<ICoreWebView2MoveFocusRequestedEventArgs>? _moveFocusRequested;
    private EventRegistrationToken _moveFocusRequestedToken;
    private EventHandler? _gotFocus;
    private EventRegistrationToken _gotFocusToken;
    private EventHandler? _lostFocus;
    private EventRegistrationToken _lostFocusToken;
    private EventHandler<ICoreWebView2AcceleratorKeyPressedEventArgs>? _acceleratorKeyPressed;
    private EventRegistrationToken _acceleratorKeyPressedToken;
    private EventHandler? _rasterizationScaleChanged;
    private EventRegistrationToken _rasterizationScaleChangedToken;

    public CoreWebView2ControllerEvents(IComObject<ICoreWebView2Controller> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2Controller Instance => _instance;

    public event EventHandler? ZoomFactorChanged
    {
        add
        {
            if (_zoomFactorChanged == null)
            {
                _instance.add_ZoomFactorChanged(new CoreWebView2ZoomFactorChangedEventHandler((sender, args) => _zoomFactorChanged?.Invoke(sender, EventArgs.Empty)), ref _zoomFactorChangedToken).ThrowOnError();
            }

            _zoomFactorChanged += value;
        }
        remove
        {
            _zoomFactorChanged -= value;
            if (_zoomFactorChanged == null)
            {
                _instance.remove_ZoomFactorChanged(_zoomFactorChangedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2MoveFocusRequestedEventArgs>? MoveFocusRequested
    {
        add
        {
            if (_moveFocusRequested == null)
            {
                _instance.add_MoveFocusRequested(new CoreWebView2MoveFocusRequestedEventHandler((sender, args) => _moveFocusRequested?.Invoke(sender, args)), ref _moveFocusRequestedToken).ThrowOnError();
            }

            _moveFocusRequested += value;
        }
        remove
        {
            _moveFocusRequested -= value;
            if (_moveFocusRequested == null)
            {
                _instance.remove_MoveFocusRequested(_moveFocusRequestedToken);
            }
        }
    }

    public event EventHandler? GotFocus
    {
        add
        {
            if (_gotFocus == null)
            {
                _instance.add_GotFocus(new CoreWebView2FocusChangedEventHandler((sender, args) => _gotFocus?.Invoke(sender, EventArgs.Empty)), ref _gotFocusToken).ThrowOnError();
            }

            _gotFocus += value;
        }
        remove
        {
            _gotFocus -= value;
            if (_gotFocus == null)
            {
                _instance.remove_GotFocus(_gotFocusToken);
            }
        }
    }

    public event EventHandler? LostFocus
    {
        add
        {
            if (_lostFocus == null)
            {
                _instance.add_LostFocus(new CoreWebView2FocusChangedEventHandler((sender, args) => _lostFocus?.Invoke(sender, EventArgs.Empty)), ref _lostFocusToken).ThrowOnError();
            }

            _lostFocus += value;
        }
        remove
        {
            _lostFocus -= value;
            if (_lostFocus == null)
            {
                _instance.remove_LostFocus(_lostFocusToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2AcceleratorKeyPressedEventArgs>? AcceleratorKeyPressed
    {
        add
        {
            if (_acceleratorKeyPressed == null)
            {
                _instance.add_AcceleratorKeyPressed(new CoreWebView2AcceleratorKeyPressedEventHandler((sender, args) => _acceleratorKeyPressed?.Invoke(sender, args)), ref _acceleratorKeyPressedToken).ThrowOnError();
            }

            _acceleratorKeyPressed += value;
        }
        remove
        {
            _acceleratorKeyPressed -= value;
            if (_acceleratorKeyPressed == null)
            {
                _instance.remove_AcceleratorKeyPressed(_acceleratorKeyPressedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Controller3"/>.</remarks>
    public event EventHandler? RasterizationScaleChanged
    {
        add
        {
            if (_rasterizationScaleChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Controller3>(_instance) is not { } typed)
                    return;

                typed.add_RasterizationScaleChanged(new CoreWebView2RasterizationScaleChangedEventHandler((sender, args) => _rasterizationScaleChanged?.Invoke(sender, EventArgs.Empty)), ref _rasterizationScaleChangedToken).ThrowOnError();
            }

            _rasterizationScaleChanged += value;
        }
        remove
        {
            _rasterizationScaleChanged -= value;
            if (_rasterizationScaleChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Controller3>(_instance)?.remove_RasterizationScaleChanged(_rasterizationScaleChangedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_zoomFactorChanged != null)
        {
            _zoomFactorChanged = null;
            _instance.remove_ZoomFactorChanged(_zoomFactorChangedToken);
        }

        if (_moveFocusRequested != null)
        {
            _moveFocusRequested = null;
            _instance.remove_MoveFocusRequested(_moveFocusRequestedToken);
        }

        if (_gotFocus != null)
        {
            _gotFocus = null;
            _instance.remove_GotFocus(_gotFocusToken);
        }

        if (_lostFocus != null)
        {
            _lostFocus = null;
            _instance.remove_LostFocus(_lostFocusToken);
        }

        if (_acceleratorKeyPressed != null)
        {
            _acceleratorKeyPressed = null;
            _instance.remove_AcceleratorKeyPressed(_acceleratorKeyPressedToken);
        }

        if (_rasterizationScaleChanged != null)
        {
            _rasterizationScaleChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2Controller3>(_instance)?.remove_RasterizationScaleChanged(_rasterizationScaleChangedToken);
        }
    }
}
