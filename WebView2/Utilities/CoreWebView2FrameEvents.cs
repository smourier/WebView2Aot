namespace WebView2.Utilities;

public sealed class CoreWebView2FrameEvents(ICoreWebView2Frame instance) : IDisposable
{
    private readonly ICoreWebView2Frame _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _nameChanged;
    private EventRegistrationToken _nameChangedToken;
    private EventHandler? _destroyed;
    private EventRegistrationToken _destroyedToken;
    private EventHandler<ICoreWebView2NavigationStartingEventArgs>? _navigationStarting;
    private EventRegistrationToken _navigationStartingToken;
    private EventHandler<ICoreWebView2ContentLoadingEventArgs>? _contentLoading;
    private EventRegistrationToken _contentLoadingToken;
    private EventHandler<ICoreWebView2NavigationCompletedEventArgs>? _navigationCompleted;
    private EventRegistrationToken _navigationCompletedToken;
    private EventHandler<ICoreWebView2DOMContentLoadedEventArgs>? _dOMContentLoaded;
    private EventRegistrationToken _dOMContentLoadedToken;
    private EventHandler<ICoreWebView2WebMessageReceivedEventArgs>? _webMessageReceived;
    private EventRegistrationToken _webMessageReceivedToken;
    private EventHandler<ICoreWebView2PermissionRequestedEventArgs2>? _permissionRequested;
    private EventRegistrationToken _permissionRequestedToken;
    private EventHandler<ICoreWebView2ScreenCaptureStartingEventArgs>? _screenCaptureStarting;
    private EventRegistrationToken _screenCaptureStartingToken;
    private EventHandler<ICoreWebView2FrameCreatedEventArgs>? _frameCreated;
    private EventRegistrationToken _frameCreatedToken;
    private EventHandler<ICoreWebView2DedicatedWorkerCreatedEventArgs>? _dedicatedWorkerCreated;
    private EventRegistrationToken _dedicatedWorkerCreatedToken;

    public CoreWebView2FrameEvents(IComObject<ICoreWebView2Frame> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2Frame Instance => _instance;

    public event EventHandler? NameChanged
    {
        add
        {
            if (_nameChanged == null)
            {
                _instance.add_NameChanged(new CoreWebView2FrameNameChangedEventHandler((sender, args) => _nameChanged?.Invoke(sender, EventArgs.Empty)), ref _nameChangedToken).ThrowOnError();
            }

            _nameChanged += value;
        }
        remove
        {
            _nameChanged -= value;
            if (_nameChanged == null)
            {
                _instance.remove_NameChanged(_nameChangedToken);
            }
        }
    }

    public event EventHandler? Destroyed
    {
        add
        {
            if (_destroyed == null)
            {
                _instance.add_Destroyed(new CoreWebView2FrameDestroyedEventHandler((sender, args) => _destroyed?.Invoke(sender, EventArgs.Empty)), ref _destroyedToken).ThrowOnError();
            }

            _destroyed += value;
        }
        remove
        {
            _destroyed -= value;
            if (_destroyed == null)
            {
                _instance.remove_Destroyed(_destroyedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public event EventHandler<ICoreWebView2NavigationStartingEventArgs>? NavigationStarting
    {
        add
        {
            if (_navigationStarting == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance) is not { } typed)
                    return;

                typed.add_NavigationStarting(new CoreWebView2FrameNavigationStartingEventHandler((sender, args) => _navigationStarting?.Invoke(sender, args)), ref _navigationStartingToken).ThrowOnError();
            }

            _navigationStarting += value;
        }
        remove
        {
            _navigationStarting -= value;
            if (_navigationStarting == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_NavigationStarting(_navigationStartingToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public event EventHandler<ICoreWebView2ContentLoadingEventArgs>? ContentLoading
    {
        add
        {
            if (_contentLoading == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance) is not { } typed)
                    return;

                typed.add_ContentLoading(new CoreWebView2FrameContentLoadingEventHandler((sender, args) => _contentLoading?.Invoke(sender, args)), ref _contentLoadingToken).ThrowOnError();
            }

            _contentLoading += value;
        }
        remove
        {
            _contentLoading -= value;
            if (_contentLoading == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_ContentLoading(_contentLoadingToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public event EventHandler<ICoreWebView2NavigationCompletedEventArgs>? NavigationCompleted
    {
        add
        {
            if (_navigationCompleted == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance) is not { } typed)
                    return;

                typed.add_NavigationCompleted(new CoreWebView2FrameNavigationCompletedEventHandler((sender, args) => _navigationCompleted?.Invoke(sender, args)), ref _navigationCompletedToken).ThrowOnError();
            }

            _navigationCompleted += value;
        }
        remove
        {
            _navigationCompleted -= value;
            if (_navigationCompleted == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_NavigationCompleted(_navigationCompletedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public event EventHandler<ICoreWebView2DOMContentLoadedEventArgs>? DOMContentLoaded
    {
        add
        {
            if (_dOMContentLoaded == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance) is not { } typed)
                    return;

                typed.add_DOMContentLoaded(new CoreWebView2FrameDOMContentLoadedEventHandler((sender, args) => _dOMContentLoaded?.Invoke(sender, args)), ref _dOMContentLoadedToken).ThrowOnError();
            }

            _dOMContentLoaded += value;
        }
        remove
        {
            _dOMContentLoaded -= value;
            if (_dOMContentLoaded == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_DOMContentLoaded(_dOMContentLoadedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public event EventHandler<ICoreWebView2WebMessageReceivedEventArgs>? WebMessageReceived
    {
        add
        {
            if (_webMessageReceived == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance) is not { } typed)
                    return;

                typed.add_WebMessageReceived(new CoreWebView2FrameWebMessageReceivedEventHandler((sender, args) => _webMessageReceived?.Invoke(sender, args)), ref _webMessageReceivedToken).ThrowOnError();
            }

            _webMessageReceived += value;
        }
        remove
        {
            _webMessageReceived -= value;
            if (_webMessageReceived == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_WebMessageReceived(_webMessageReceivedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame3"/>.</remarks>
    public event EventHandler<ICoreWebView2PermissionRequestedEventArgs2>? PermissionRequested
    {
        add
        {
            if (_permissionRequested == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame3>(_instance) is not { } typed)
                    return;

                typed.add_PermissionRequested(new CoreWebView2FramePermissionRequestedEventHandler((sender, args) => _permissionRequested?.Invoke(sender, args)), ref _permissionRequestedToken).ThrowOnError();
            }

            _permissionRequested += value;
        }
        remove
        {
            _permissionRequested -= value;
            if (_permissionRequested == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame3>(_instance)?.remove_PermissionRequested(_permissionRequestedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame6"/>.</remarks>
    public event EventHandler<ICoreWebView2ScreenCaptureStartingEventArgs>? ScreenCaptureStarting
    {
        add
        {
            if (_screenCaptureStarting == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame6>(_instance) is not { } typed)
                    return;

                typed.add_ScreenCaptureStarting(new CoreWebView2FrameScreenCaptureStartingEventHandler((sender, args) => _screenCaptureStarting?.Invoke(sender, args)), ref _screenCaptureStartingToken).ThrowOnError();
            }

            _screenCaptureStarting += value;
        }
        remove
        {
            _screenCaptureStarting -= value;
            if (_screenCaptureStarting == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame6>(_instance)?.remove_ScreenCaptureStarting(_screenCaptureStartingToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame7"/>.</remarks>
    public event EventHandler<ICoreWebView2FrameCreatedEventArgs>? FrameCreated
    {
        add
        {
            if (_frameCreated == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame7>(_instance) is not { } typed)
                    return;

                typed.add_FrameCreated(new CoreWebView2FrameChildFrameCreatedEventHandler((sender, args) => _frameCreated?.Invoke(sender, args)), ref _frameCreatedToken).ThrowOnError();
            }

            _frameCreated += value;
        }
        remove
        {
            _frameCreated -= value;
            if (_frameCreated == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame7>(_instance)?.remove_FrameCreated(_frameCreatedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame8"/>.</remarks>
    public event EventHandler<ICoreWebView2DedicatedWorkerCreatedEventArgs>? DedicatedWorkerCreated
    {
        add
        {
            if (_dedicatedWorkerCreated == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Frame8>(_instance) is not { } typed)
                    return;

                typed.add_DedicatedWorkerCreated(new CoreWebView2FrameDedicatedWorkerCreatedEventHandler((sender, args) => _dedicatedWorkerCreated?.Invoke(sender, args)), ref _dedicatedWorkerCreatedToken).ThrowOnError();
            }

            _dedicatedWorkerCreated += value;
        }
        remove
        {
            _dedicatedWorkerCreated -= value;
            if (_dedicatedWorkerCreated == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Frame8>(_instance)?.remove_DedicatedWorkerCreated(_dedicatedWorkerCreatedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_nameChanged != null)
        {
            _nameChanged = null;
            _instance.remove_NameChanged(_nameChangedToken);
        }

        if (_destroyed != null)
        {
            _destroyed = null;
            _instance.remove_Destroyed(_destroyedToken);
        }

        if (_navigationStarting != null)
        {
            _navigationStarting = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_NavigationStarting(_navigationStartingToken);
        }

        if (_contentLoading != null)
        {
            _contentLoading = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_ContentLoading(_contentLoadingToken);
        }

        if (_navigationCompleted != null)
        {
            _navigationCompleted = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_NavigationCompleted(_navigationCompletedToken);
        }

        if (_dOMContentLoaded != null)
        {
            _dOMContentLoaded = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_DOMContentLoaded(_dOMContentLoadedToken);
        }

        if (_webMessageReceived != null)
        {
            _webMessageReceived = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame2>(_instance)?.remove_WebMessageReceived(_webMessageReceivedToken);
        }

        if (_permissionRequested != null)
        {
            _permissionRequested = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame3>(_instance)?.remove_PermissionRequested(_permissionRequestedToken);
        }

        if (_screenCaptureStarting != null)
        {
            _screenCaptureStarting = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame6>(_instance)?.remove_ScreenCaptureStarting(_screenCaptureStartingToken);
        }

        if (_frameCreated != null)
        {
            _frameCreated = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame7>(_instance)?.remove_FrameCreated(_frameCreatedToken);
        }

        if (_dedicatedWorkerCreated != null)
        {
            _dedicatedWorkerCreated = null;
            WebView2Utilities.GetInterface<ICoreWebView2Frame8>(_instance)?.remove_DedicatedWorkerCreated(_dedicatedWorkerCreatedToken);
        }
    }
}
