namespace WebView2.Utilities;

public sealed class CoreWebView2Events(ICoreWebView2 instance) : IDisposable
{
    private readonly ICoreWebView2 _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler<ICoreWebView2NavigationStartingEventArgs>? _navigationStarting;
    private EventRegistrationToken _navigationStartingToken;
    private EventHandler<ICoreWebView2ContentLoadingEventArgs>? _contentLoading;
    private EventRegistrationToken _contentLoadingToken;
    private EventHandler<ICoreWebView2SourceChangedEventArgs>? _sourceChanged;
    private EventRegistrationToken _sourceChangedToken;
    private EventHandler? _historyChanged;
    private EventRegistrationToken _historyChangedToken;
    private EventHandler<ICoreWebView2NavigationCompletedEventArgs>? _navigationCompleted;
    private EventRegistrationToken _navigationCompletedToken;
    private EventHandler<ICoreWebView2NavigationStartingEventArgs>? _frameNavigationStarting;
    private EventRegistrationToken _frameNavigationStartingToken;
    private EventHandler<ICoreWebView2NavigationCompletedEventArgs>? _frameNavigationCompleted;
    private EventRegistrationToken _frameNavigationCompletedToken;
    private EventHandler<ICoreWebView2ScriptDialogOpeningEventArgs>? _scriptDialogOpening;
    private EventRegistrationToken _scriptDialogOpeningToken;
    private EventHandler<ICoreWebView2PermissionRequestedEventArgs>? _permissionRequested;
    private EventRegistrationToken _permissionRequestedToken;
    private EventHandler<ICoreWebView2ProcessFailedEventArgs>? _processFailed;
    private EventRegistrationToken _processFailedToken;
    private EventHandler<ICoreWebView2WebMessageReceivedEventArgs>? _webMessageReceived;
    private EventRegistrationToken _webMessageReceivedToken;
    private EventHandler<ICoreWebView2NewWindowRequestedEventArgs>? _newWindowRequested;
    private EventRegistrationToken _newWindowRequestedToken;
    private EventHandler? _documentTitleChanged;
    private EventRegistrationToken _documentTitleChangedToken;
    private EventHandler? _containsFullScreenElementChanged;
    private EventRegistrationToken _containsFullScreenElementChangedToken;
    private EventHandler<ICoreWebView2WebResourceRequestedEventArgs>? _webResourceRequested;
    private EventRegistrationToken _webResourceRequestedToken;
    private EventHandler? _windowCloseRequested;
    private EventRegistrationToken _windowCloseRequestedToken;
    private EventHandler<ICoreWebView2WebResourceResponseReceivedEventArgs>? _webResourceResponseReceived;
    private EventRegistrationToken _webResourceResponseReceivedToken;
    private EventHandler<ICoreWebView2DOMContentLoadedEventArgs>? _dOMContentLoaded;
    private EventRegistrationToken _dOMContentLoadedToken;
    private EventHandler<ICoreWebView2FrameCreatedEventArgs>? _frameCreated;
    private EventRegistrationToken _frameCreatedToken;
    private EventHandler<ICoreWebView2DownloadStartingEventArgs>? _downloadStarting;
    private EventRegistrationToken _downloadStartingToken;
    private EventHandler<ICoreWebView2ClientCertificateRequestedEventArgs>? _clientCertificateRequested;
    private EventRegistrationToken _clientCertificateRequestedToken;
    private EventHandler? _isMutedChanged;
    private EventRegistrationToken _isMutedChangedToken;
    private EventHandler? _isDocumentPlayingAudioChanged;
    private EventRegistrationToken _isDocumentPlayingAudioChangedToken;
    private EventHandler? _isDefaultDownloadDialogOpenChanged;
    private EventRegistrationToken _isDefaultDownloadDialogOpenChangedToken;
    private EventHandler<ICoreWebView2BasicAuthenticationRequestedEventArgs>? _basicAuthenticationRequested;
    private EventRegistrationToken _basicAuthenticationRequestedToken;
    private EventHandler<ICoreWebView2ContextMenuRequestedEventArgs>? _contextMenuRequested;
    private EventRegistrationToken _contextMenuRequestedToken;
    private EventHandler? _statusBarTextChanged;
    private EventRegistrationToken _statusBarTextChangedToken;
    private EventHandler<ICoreWebView2ServerCertificateErrorDetectedEventArgs>? _serverCertificateErrorDetected;
    private EventRegistrationToken _serverCertificateErrorDetectedToken;
    private EventHandler? _faviconChanged;
    private EventRegistrationToken _faviconChangedToken;
    private EventHandler<ICoreWebView2LaunchingExternalUriSchemeEventArgs>? _launchingExternalUriScheme;
    private EventRegistrationToken _launchingExternalUriSchemeToken;
    private EventHandler<ICoreWebView2NotificationReceivedEventArgs>? _notificationReceived;
    private EventRegistrationToken _notificationReceivedToken;
    private EventHandler<ICoreWebView2SaveAsUIShowingEventArgs>? _saveAsUIShowing;
    private EventRegistrationToken _saveAsUIShowingToken;
    private EventHandler<ICoreWebView2SaveFileSecurityCheckStartingEventArgs>? _saveFileSecurityCheckStarting;
    private EventRegistrationToken _saveFileSecurityCheckStartingToken;
    private EventHandler<ICoreWebView2ScreenCaptureStartingEventArgs>? _screenCaptureStarting;
    private EventRegistrationToken _screenCaptureStartingToken;
    private EventHandler<ICoreWebView2DedicatedWorkerCreatedEventArgs>? _dedicatedWorkerCreated;
    private EventRegistrationToken _dedicatedWorkerCreatedToken;

    public CoreWebView2Events(IComObject<ICoreWebView2> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2 Instance => _instance;

    public event EventHandler<ICoreWebView2NavigationStartingEventArgs>? NavigationStarting
    {
        add
        {
            if (_navigationStarting == null)
            {
                _instance.add_NavigationStarting(new CoreWebView2NavigationStartingEventHandler((sender, args) => _navigationStarting?.Invoke(sender, args)), ref _navigationStartingToken).ThrowOnError();
            }

            _navigationStarting += value;
        }
        remove
        {
            _navigationStarting -= value;
            if (_navigationStarting == null)
            {
                _instance.remove_NavigationStarting(_navigationStartingToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2ContentLoadingEventArgs>? ContentLoading
    {
        add
        {
            if (_contentLoading == null)
            {
                _instance.add_ContentLoading(new CoreWebView2ContentLoadingEventHandler((sender, args) => _contentLoading?.Invoke(sender, args)), ref _contentLoadingToken).ThrowOnError();
            }

            _contentLoading += value;
        }
        remove
        {
            _contentLoading -= value;
            if (_contentLoading == null)
            {
                _instance.remove_ContentLoading(_contentLoadingToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2SourceChangedEventArgs>? SourceChanged
    {
        add
        {
            if (_sourceChanged == null)
            {
                _instance.add_SourceChanged(new CoreWebView2SourceChangedEventHandler((sender, args) => _sourceChanged?.Invoke(sender, args)), ref _sourceChangedToken).ThrowOnError();
            }

            _sourceChanged += value;
        }
        remove
        {
            _sourceChanged -= value;
            if (_sourceChanged == null)
            {
                _instance.remove_SourceChanged(_sourceChangedToken);
            }
        }
    }

    public event EventHandler? HistoryChanged
    {
        add
        {
            if (_historyChanged == null)
            {
                _instance.add_HistoryChanged(new CoreWebView2HistoryChangedEventHandler((sender, args) => _historyChanged?.Invoke(sender, EventArgs.Empty)), ref _historyChangedToken).ThrowOnError();
            }

            _historyChanged += value;
        }
        remove
        {
            _historyChanged -= value;
            if (_historyChanged == null)
            {
                _instance.remove_HistoryChanged(_historyChangedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2NavigationCompletedEventArgs>? NavigationCompleted
    {
        add
        {
            if (_navigationCompleted == null)
            {
                _instance.add_NavigationCompleted(new CoreWebView2NavigationCompletedEventHandler((sender, args) => _navigationCompleted?.Invoke(sender, args)), ref _navigationCompletedToken).ThrowOnError();
            }

            _navigationCompleted += value;
        }
        remove
        {
            _navigationCompleted -= value;
            if (_navigationCompleted == null)
            {
                _instance.remove_NavigationCompleted(_navigationCompletedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2NavigationStartingEventArgs>? FrameNavigationStarting
    {
        add
        {
            if (_frameNavigationStarting == null)
            {
                _instance.add_FrameNavigationStarting(new CoreWebView2NavigationStartingEventHandler((sender, args) => _frameNavigationStarting?.Invoke(sender, args)), ref _frameNavigationStartingToken).ThrowOnError();
            }

            _frameNavigationStarting += value;
        }
        remove
        {
            _frameNavigationStarting -= value;
            if (_frameNavigationStarting == null)
            {
                _instance.remove_FrameNavigationStarting(_frameNavigationStartingToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2NavigationCompletedEventArgs>? FrameNavigationCompleted
    {
        add
        {
            if (_frameNavigationCompleted == null)
            {
                _instance.add_FrameNavigationCompleted(new CoreWebView2NavigationCompletedEventHandler((sender, args) => _frameNavigationCompleted?.Invoke(sender, args)), ref _frameNavigationCompletedToken).ThrowOnError();
            }

            _frameNavigationCompleted += value;
        }
        remove
        {
            _frameNavigationCompleted -= value;
            if (_frameNavigationCompleted == null)
            {
                _instance.remove_FrameNavigationCompleted(_frameNavigationCompletedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2ScriptDialogOpeningEventArgs>? ScriptDialogOpening
    {
        add
        {
            if (_scriptDialogOpening == null)
            {
                _instance.add_ScriptDialogOpening(new CoreWebView2ScriptDialogOpeningEventHandler((sender, args) => _scriptDialogOpening?.Invoke(sender, args)), ref _scriptDialogOpeningToken).ThrowOnError();
            }

            _scriptDialogOpening += value;
        }
        remove
        {
            _scriptDialogOpening -= value;
            if (_scriptDialogOpening == null)
            {
                _instance.remove_ScriptDialogOpening(_scriptDialogOpeningToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2PermissionRequestedEventArgs>? PermissionRequested
    {
        add
        {
            if (_permissionRequested == null)
            {
                _instance.add_PermissionRequested(new CoreWebView2PermissionRequestedEventHandler((sender, args) => _permissionRequested?.Invoke(sender, args)), ref _permissionRequestedToken).ThrowOnError();
            }

            _permissionRequested += value;
        }
        remove
        {
            _permissionRequested -= value;
            if (_permissionRequested == null)
            {
                _instance.remove_PermissionRequested(_permissionRequestedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2ProcessFailedEventArgs>? ProcessFailed
    {
        add
        {
            if (_processFailed == null)
            {
                _instance.add_ProcessFailed(new CoreWebView2ProcessFailedEventHandler((sender, args) => _processFailed?.Invoke(sender, args)), ref _processFailedToken).ThrowOnError();
            }

            _processFailed += value;
        }
        remove
        {
            _processFailed -= value;
            if (_processFailed == null)
            {
                _instance.remove_ProcessFailed(_processFailedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2WebMessageReceivedEventArgs>? WebMessageReceived
    {
        add
        {
            if (_webMessageReceived == null)
            {
                _instance.add_WebMessageReceived(new CoreWebView2WebMessageReceivedEventHandler((sender, args) => _webMessageReceived?.Invoke(sender, args)), ref _webMessageReceivedToken).ThrowOnError();
            }

            _webMessageReceived += value;
        }
        remove
        {
            _webMessageReceived -= value;
            if (_webMessageReceived == null)
            {
                _instance.remove_WebMessageReceived(_webMessageReceivedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2NewWindowRequestedEventArgs>? NewWindowRequested
    {
        add
        {
            if (_newWindowRequested == null)
            {
                _instance.add_NewWindowRequested(new CoreWebView2NewWindowRequestedEventHandler((sender, args) => _newWindowRequested?.Invoke(sender, args)), ref _newWindowRequestedToken).ThrowOnError();
            }

            _newWindowRequested += value;
        }
        remove
        {
            _newWindowRequested -= value;
            if (_newWindowRequested == null)
            {
                _instance.remove_NewWindowRequested(_newWindowRequestedToken);
            }
        }
    }

    public event EventHandler? DocumentTitleChanged
    {
        add
        {
            if (_documentTitleChanged == null)
            {
                _instance.add_DocumentTitleChanged(new CoreWebView2DocumentTitleChangedEventHandler((sender, args) => _documentTitleChanged?.Invoke(sender, EventArgs.Empty)), ref _documentTitleChangedToken).ThrowOnError();
            }

            _documentTitleChanged += value;
        }
        remove
        {
            _documentTitleChanged -= value;
            if (_documentTitleChanged == null)
            {
                _instance.remove_DocumentTitleChanged(_documentTitleChangedToken);
            }
        }
    }

    public event EventHandler? ContainsFullScreenElementChanged
    {
        add
        {
            if (_containsFullScreenElementChanged == null)
            {
                _instance.add_ContainsFullScreenElementChanged(new CoreWebView2ContainsFullScreenElementChangedEventHandler((sender, args) => _containsFullScreenElementChanged?.Invoke(sender, EventArgs.Empty)), ref _containsFullScreenElementChangedToken).ThrowOnError();
            }

            _containsFullScreenElementChanged += value;
        }
        remove
        {
            _containsFullScreenElementChanged -= value;
            if (_containsFullScreenElementChanged == null)
            {
                _instance.remove_ContainsFullScreenElementChanged(_containsFullScreenElementChangedToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2WebResourceRequestedEventArgs>? WebResourceRequested
    {
        add
        {
            if (_webResourceRequested == null)
            {
                _instance.add_WebResourceRequested(new CoreWebView2WebResourceRequestedEventHandler((sender, args) => _webResourceRequested?.Invoke(sender, args)), ref _webResourceRequestedToken).ThrowOnError();
            }

            _webResourceRequested += value;
        }
        remove
        {
            _webResourceRequested -= value;
            if (_webResourceRequested == null)
            {
                _instance.remove_WebResourceRequested(_webResourceRequestedToken);
            }
        }
    }

    public event EventHandler? WindowCloseRequested
    {
        add
        {
            if (_windowCloseRequested == null)
            {
                _instance.add_WindowCloseRequested(new CoreWebView2WindowCloseRequestedEventHandler((sender, args) => _windowCloseRequested?.Invoke(sender, EventArgs.Empty)), ref _windowCloseRequestedToken).ThrowOnError();
            }

            _windowCloseRequested += value;
        }
        remove
        {
            _windowCloseRequested -= value;
            if (_windowCloseRequested == null)
            {
                _instance.remove_WindowCloseRequested(_windowCloseRequestedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
    public event EventHandler<ICoreWebView2WebResourceResponseReceivedEventArgs>? WebResourceResponseReceived
    {
        add
        {
            if (_webResourceResponseReceived == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_2>(_instance) is not { } typed)
                    return;

                typed.add_WebResourceResponseReceived(new CoreWebView2WebResourceResponseReceivedEventHandler((sender, args) => _webResourceResponseReceived?.Invoke(sender, args)), ref _webResourceResponseReceivedToken).ThrowOnError();
            }

            _webResourceResponseReceived += value;
        }
        remove
        {
            _webResourceResponseReceived -= value;
            if (_webResourceResponseReceived == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_2>(_instance)?.remove_WebResourceResponseReceived(_webResourceResponseReceivedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
    public event EventHandler<ICoreWebView2DOMContentLoadedEventArgs>? DOMContentLoaded
    {
        add
        {
            if (_dOMContentLoaded == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_2>(_instance) is not { } typed)
                    return;

                typed.add_DOMContentLoaded(new CoreWebView2DOMContentLoadedEventHandler((sender, args) => _dOMContentLoaded?.Invoke(sender, args)), ref _dOMContentLoadedToken).ThrowOnError();
            }

            _dOMContentLoaded += value;
        }
        remove
        {
            _dOMContentLoaded -= value;
            if (_dOMContentLoaded == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_2>(_instance)?.remove_DOMContentLoaded(_dOMContentLoadedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_4"/>.</remarks>
    public event EventHandler<ICoreWebView2FrameCreatedEventArgs>? FrameCreated
    {
        add
        {
            if (_frameCreated == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_4>(_instance) is not { } typed)
                    return;

                typed.add_FrameCreated(new CoreWebView2FrameCreatedEventHandler((sender, args) => _frameCreated?.Invoke(sender, args)), ref _frameCreatedToken).ThrowOnError();
            }

            _frameCreated += value;
        }
        remove
        {
            _frameCreated -= value;
            if (_frameCreated == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_4>(_instance)?.remove_FrameCreated(_frameCreatedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_4"/>.</remarks>
    public event EventHandler<ICoreWebView2DownloadStartingEventArgs>? DownloadStarting
    {
        add
        {
            if (_downloadStarting == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_4>(_instance) is not { } typed)
                    return;

                typed.add_DownloadStarting(new CoreWebView2DownloadStartingEventHandler((sender, args) => _downloadStarting?.Invoke(sender, args)), ref _downloadStartingToken).ThrowOnError();
            }

            _downloadStarting += value;
        }
        remove
        {
            _downloadStarting -= value;
            if (_downloadStarting == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_4>(_instance)?.remove_DownloadStarting(_downloadStartingToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_5"/>.</remarks>
    public event EventHandler<ICoreWebView2ClientCertificateRequestedEventArgs>? ClientCertificateRequested
    {
        add
        {
            if (_clientCertificateRequested == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_5>(_instance) is not { } typed)
                    return;

                typed.add_ClientCertificateRequested(new CoreWebView2ClientCertificateRequestedEventHandler((sender, args) => _clientCertificateRequested?.Invoke(sender, args)), ref _clientCertificateRequestedToken).ThrowOnError();
            }

            _clientCertificateRequested += value;
        }
        remove
        {
            _clientCertificateRequested -= value;
            if (_clientCertificateRequested == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_5>(_instance)?.remove_ClientCertificateRequested(_clientCertificateRequestedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_8"/>.</remarks>
    public event EventHandler? IsMutedChanged
    {
        add
        {
            if (_isMutedChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_8>(_instance) is not { } typed)
                    return;

                typed.add_IsMutedChanged(new CoreWebView2IsMutedChangedEventHandler((sender, args) => _isMutedChanged?.Invoke(sender, EventArgs.Empty)), ref _isMutedChangedToken).ThrowOnError();
            }

            _isMutedChanged += value;
        }
        remove
        {
            _isMutedChanged -= value;
            if (_isMutedChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_8>(_instance)?.remove_IsMutedChanged(_isMutedChangedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_8"/>.</remarks>
    public event EventHandler? IsDocumentPlayingAudioChanged
    {
        add
        {
            if (_isDocumentPlayingAudioChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_8>(_instance) is not { } typed)
                    return;

                typed.add_IsDocumentPlayingAudioChanged(new CoreWebView2IsDocumentPlayingAudioChangedEventHandler((sender, args) => _isDocumentPlayingAudioChanged?.Invoke(sender, EventArgs.Empty)), ref _isDocumentPlayingAudioChangedToken).ThrowOnError();
            }

            _isDocumentPlayingAudioChanged += value;
        }
        remove
        {
            _isDocumentPlayingAudioChanged -= value;
            if (_isDocumentPlayingAudioChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_8>(_instance)?.remove_IsDocumentPlayingAudioChanged(_isDocumentPlayingAudioChangedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
    public event EventHandler? IsDefaultDownloadDialogOpenChanged
    {
        add
        {
            if (_isDefaultDownloadDialogOpenChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_9>(_instance) is not { } typed)
                    return;

                typed.add_IsDefaultDownloadDialogOpenChanged(new CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler((sender, args) => _isDefaultDownloadDialogOpenChanged?.Invoke(sender, EventArgs.Empty)), ref _isDefaultDownloadDialogOpenChangedToken).ThrowOnError();
            }

            _isDefaultDownloadDialogOpenChanged += value;
        }
        remove
        {
            _isDefaultDownloadDialogOpenChanged -= value;
            if (_isDefaultDownloadDialogOpenChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_9>(_instance)?.remove_IsDefaultDownloadDialogOpenChanged(_isDefaultDownloadDialogOpenChangedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_10"/>.</remarks>
    public event EventHandler<ICoreWebView2BasicAuthenticationRequestedEventArgs>? BasicAuthenticationRequested
    {
        add
        {
            if (_basicAuthenticationRequested == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_10>(_instance) is not { } typed)
                    return;

                typed.add_BasicAuthenticationRequested(new CoreWebView2BasicAuthenticationRequestedEventHandler((sender, args) => _basicAuthenticationRequested?.Invoke(sender, args)), ref _basicAuthenticationRequestedToken).ThrowOnError();
            }

            _basicAuthenticationRequested += value;
        }
        remove
        {
            _basicAuthenticationRequested -= value;
            if (_basicAuthenticationRequested == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_10>(_instance)?.remove_BasicAuthenticationRequested(_basicAuthenticationRequestedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_11"/>.</remarks>
    public event EventHandler<ICoreWebView2ContextMenuRequestedEventArgs>? ContextMenuRequested
    {
        add
        {
            if (_contextMenuRequested == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_11>(_instance) is not { } typed)
                    return;

                typed.add_ContextMenuRequested(new CoreWebView2ContextMenuRequestedEventHandler((sender, args) => _contextMenuRequested?.Invoke(sender, args)), ref _contextMenuRequestedToken).ThrowOnError();
            }

            _contextMenuRequested += value;
        }
        remove
        {
            _contextMenuRequested -= value;
            if (_contextMenuRequested == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_11>(_instance)?.remove_ContextMenuRequested(_contextMenuRequestedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_12"/>.</remarks>
    public event EventHandler? StatusBarTextChanged
    {
        add
        {
            if (_statusBarTextChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_12>(_instance) is not { } typed)
                    return;

                typed.add_StatusBarTextChanged(new CoreWebView2StatusBarTextChangedEventHandler((sender, args) => _statusBarTextChanged?.Invoke(sender, EventArgs.Empty)), ref _statusBarTextChangedToken).ThrowOnError();
            }

            _statusBarTextChanged += value;
        }
        remove
        {
            _statusBarTextChanged -= value;
            if (_statusBarTextChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_12>(_instance)?.remove_StatusBarTextChanged(_statusBarTextChangedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_14"/>.</remarks>
    public event EventHandler<ICoreWebView2ServerCertificateErrorDetectedEventArgs>? ServerCertificateErrorDetected
    {
        add
        {
            if (_serverCertificateErrorDetected == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_14>(_instance) is not { } typed)
                    return;

                typed.add_ServerCertificateErrorDetected(new CoreWebView2ServerCertificateErrorDetectedEventHandler((sender, args) => _serverCertificateErrorDetected?.Invoke(sender, args)), ref _serverCertificateErrorDetectedToken).ThrowOnError();
            }

            _serverCertificateErrorDetected += value;
        }
        remove
        {
            _serverCertificateErrorDetected -= value;
            if (_serverCertificateErrorDetected == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_14>(_instance)?.remove_ServerCertificateErrorDetected(_serverCertificateErrorDetectedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_15"/>.</remarks>
    public event EventHandler? FaviconChanged
    {
        add
        {
            if (_faviconChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_15>(_instance) is not { } typed)
                    return;

                typed.add_FaviconChanged(new CoreWebView2FaviconChangedEventHandler((sender, args) => _faviconChanged?.Invoke(sender, EventArgs.Empty)), ref _faviconChangedToken).ThrowOnError();
            }

            _faviconChanged += value;
        }
        remove
        {
            _faviconChanged -= value;
            if (_faviconChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_15>(_instance)?.remove_FaviconChanged(_faviconChangedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_18"/>.</remarks>
    public event EventHandler<ICoreWebView2LaunchingExternalUriSchemeEventArgs>? LaunchingExternalUriScheme
    {
        add
        {
            if (_launchingExternalUriScheme == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_18>(_instance) is not { } typed)
                    return;

                typed.add_LaunchingExternalUriScheme(new CoreWebView2LaunchingExternalUriSchemeEventHandler((sender, args) => _launchingExternalUriScheme?.Invoke(sender, args)), ref _launchingExternalUriSchemeToken).ThrowOnError();
            }

            _launchingExternalUriScheme += value;
        }
        remove
        {
            _launchingExternalUriScheme -= value;
            if (_launchingExternalUriScheme == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_18>(_instance)?.remove_LaunchingExternalUriScheme(_launchingExternalUriSchemeToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_24"/>.</remarks>
    public event EventHandler<ICoreWebView2NotificationReceivedEventArgs>? NotificationReceived
    {
        add
        {
            if (_notificationReceived == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_24>(_instance) is not { } typed)
                    return;

                typed.add_NotificationReceived(new CoreWebView2NotificationReceivedEventHandler((sender, args) => _notificationReceived?.Invoke(sender, args)), ref _notificationReceivedToken).ThrowOnError();
            }

            _notificationReceived += value;
        }
        remove
        {
            _notificationReceived -= value;
            if (_notificationReceived == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_24>(_instance)?.remove_NotificationReceived(_notificationReceivedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_25"/>.</remarks>
    public event EventHandler<ICoreWebView2SaveAsUIShowingEventArgs>? SaveAsUIShowing
    {
        add
        {
            if (_saveAsUIShowing == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_25>(_instance) is not { } typed)
                    return;

                typed.add_SaveAsUIShowing(new CoreWebView2SaveAsUIShowingEventHandler((sender, args) => _saveAsUIShowing?.Invoke(sender, args)), ref _saveAsUIShowingToken).ThrowOnError();
            }

            _saveAsUIShowing += value;
        }
        remove
        {
            _saveAsUIShowing -= value;
            if (_saveAsUIShowing == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_25>(_instance)?.remove_SaveAsUIShowing(_saveAsUIShowingToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_26"/>.</remarks>
    public event EventHandler<ICoreWebView2SaveFileSecurityCheckStartingEventArgs>? SaveFileSecurityCheckStarting
    {
        add
        {
            if (_saveFileSecurityCheckStarting == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_26>(_instance) is not { } typed)
                    return;

                typed.add_SaveFileSecurityCheckStarting(new CoreWebView2SaveFileSecurityCheckStartingEventHandler((sender, args) => _saveFileSecurityCheckStarting?.Invoke(sender, args)), ref _saveFileSecurityCheckStartingToken).ThrowOnError();
            }

            _saveFileSecurityCheckStarting += value;
        }
        remove
        {
            _saveFileSecurityCheckStarting -= value;
            if (_saveFileSecurityCheckStarting == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_26>(_instance)?.remove_SaveFileSecurityCheckStarting(_saveFileSecurityCheckStartingToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_27"/>.</remarks>
    public event EventHandler<ICoreWebView2ScreenCaptureStartingEventArgs>? ScreenCaptureStarting
    {
        add
        {
            if (_screenCaptureStarting == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_27>(_instance) is not { } typed)
                    return;

                typed.add_ScreenCaptureStarting(new CoreWebView2ScreenCaptureStartingEventHandler((sender, args) => _screenCaptureStarting?.Invoke(sender, args)), ref _screenCaptureStartingToken).ThrowOnError();
            }

            _screenCaptureStarting += value;
        }
        remove
        {
            _screenCaptureStarting -= value;
            if (_screenCaptureStarting == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_27>(_instance)?.remove_ScreenCaptureStarting(_screenCaptureStartingToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2_29"/>.</remarks>
    public event EventHandler<ICoreWebView2DedicatedWorkerCreatedEventArgs>? DedicatedWorkerCreated
    {
        add
        {
            if (_dedicatedWorkerCreated == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2_29>(_instance) is not { } typed)
                    return;

                typed.add_DedicatedWorkerCreated(new CoreWebView2DedicatedWorkerCreatedEventHandler((sender, args) => _dedicatedWorkerCreated?.Invoke(sender, args)), ref _dedicatedWorkerCreatedToken).ThrowOnError();
            }

            _dedicatedWorkerCreated += value;
        }
        remove
        {
            _dedicatedWorkerCreated -= value;
            if (_dedicatedWorkerCreated == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2_29>(_instance)?.remove_DedicatedWorkerCreated(_dedicatedWorkerCreatedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_navigationStarting != null)
        {
            _navigationStarting = null;
            _instance.remove_NavigationStarting(_navigationStartingToken);
        }

        if (_contentLoading != null)
        {
            _contentLoading = null;
            _instance.remove_ContentLoading(_contentLoadingToken);
        }

        if (_sourceChanged != null)
        {
            _sourceChanged = null;
            _instance.remove_SourceChanged(_sourceChangedToken);
        }

        if (_historyChanged != null)
        {
            _historyChanged = null;
            _instance.remove_HistoryChanged(_historyChangedToken);
        }

        if (_navigationCompleted != null)
        {
            _navigationCompleted = null;
            _instance.remove_NavigationCompleted(_navigationCompletedToken);
        }

        if (_frameNavigationStarting != null)
        {
            _frameNavigationStarting = null;
            _instance.remove_FrameNavigationStarting(_frameNavigationStartingToken);
        }

        if (_frameNavigationCompleted != null)
        {
            _frameNavigationCompleted = null;
            _instance.remove_FrameNavigationCompleted(_frameNavigationCompletedToken);
        }

        if (_scriptDialogOpening != null)
        {
            _scriptDialogOpening = null;
            _instance.remove_ScriptDialogOpening(_scriptDialogOpeningToken);
        }

        if (_permissionRequested != null)
        {
            _permissionRequested = null;
            _instance.remove_PermissionRequested(_permissionRequestedToken);
        }

        if (_processFailed != null)
        {
            _processFailed = null;
            _instance.remove_ProcessFailed(_processFailedToken);
        }

        if (_webMessageReceived != null)
        {
            _webMessageReceived = null;
            _instance.remove_WebMessageReceived(_webMessageReceivedToken);
        }

        if (_newWindowRequested != null)
        {
            _newWindowRequested = null;
            _instance.remove_NewWindowRequested(_newWindowRequestedToken);
        }

        if (_documentTitleChanged != null)
        {
            _documentTitleChanged = null;
            _instance.remove_DocumentTitleChanged(_documentTitleChangedToken);
        }

        if (_containsFullScreenElementChanged != null)
        {
            _containsFullScreenElementChanged = null;
            _instance.remove_ContainsFullScreenElementChanged(_containsFullScreenElementChangedToken);
        }

        if (_webResourceRequested != null)
        {
            _webResourceRequested = null;
            _instance.remove_WebResourceRequested(_webResourceRequestedToken);
        }

        if (_windowCloseRequested != null)
        {
            _windowCloseRequested = null;
            _instance.remove_WindowCloseRequested(_windowCloseRequestedToken);
        }

        if (_webResourceResponseReceived != null)
        {
            _webResourceResponseReceived = null;
            WebView2Utilities.GetInterface<ICoreWebView2_2>(_instance)?.remove_WebResourceResponseReceived(_webResourceResponseReceivedToken);
        }

        if (_dOMContentLoaded != null)
        {
            _dOMContentLoaded = null;
            WebView2Utilities.GetInterface<ICoreWebView2_2>(_instance)?.remove_DOMContentLoaded(_dOMContentLoadedToken);
        }

        if (_frameCreated != null)
        {
            _frameCreated = null;
            WebView2Utilities.GetInterface<ICoreWebView2_4>(_instance)?.remove_FrameCreated(_frameCreatedToken);
        }

        if (_downloadStarting != null)
        {
            _downloadStarting = null;
            WebView2Utilities.GetInterface<ICoreWebView2_4>(_instance)?.remove_DownloadStarting(_downloadStartingToken);
        }

        if (_clientCertificateRequested != null)
        {
            _clientCertificateRequested = null;
            WebView2Utilities.GetInterface<ICoreWebView2_5>(_instance)?.remove_ClientCertificateRequested(_clientCertificateRequestedToken);
        }

        if (_isMutedChanged != null)
        {
            _isMutedChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2_8>(_instance)?.remove_IsMutedChanged(_isMutedChangedToken);
        }

        if (_isDocumentPlayingAudioChanged != null)
        {
            _isDocumentPlayingAudioChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2_8>(_instance)?.remove_IsDocumentPlayingAudioChanged(_isDocumentPlayingAudioChangedToken);
        }

        if (_isDefaultDownloadDialogOpenChanged != null)
        {
            _isDefaultDownloadDialogOpenChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2_9>(_instance)?.remove_IsDefaultDownloadDialogOpenChanged(_isDefaultDownloadDialogOpenChangedToken);
        }

        if (_basicAuthenticationRequested != null)
        {
            _basicAuthenticationRequested = null;
            WebView2Utilities.GetInterface<ICoreWebView2_10>(_instance)?.remove_BasicAuthenticationRequested(_basicAuthenticationRequestedToken);
        }

        if (_contextMenuRequested != null)
        {
            _contextMenuRequested = null;
            WebView2Utilities.GetInterface<ICoreWebView2_11>(_instance)?.remove_ContextMenuRequested(_contextMenuRequestedToken);
        }

        if (_statusBarTextChanged != null)
        {
            _statusBarTextChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2_12>(_instance)?.remove_StatusBarTextChanged(_statusBarTextChangedToken);
        }

        if (_serverCertificateErrorDetected != null)
        {
            _serverCertificateErrorDetected = null;
            WebView2Utilities.GetInterface<ICoreWebView2_14>(_instance)?.remove_ServerCertificateErrorDetected(_serverCertificateErrorDetectedToken);
        }

        if (_faviconChanged != null)
        {
            _faviconChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2_15>(_instance)?.remove_FaviconChanged(_faviconChangedToken);
        }

        if (_launchingExternalUriScheme != null)
        {
            _launchingExternalUriScheme = null;
            WebView2Utilities.GetInterface<ICoreWebView2_18>(_instance)?.remove_LaunchingExternalUriScheme(_launchingExternalUriSchemeToken);
        }

        if (_notificationReceived != null)
        {
            _notificationReceived = null;
            WebView2Utilities.GetInterface<ICoreWebView2_24>(_instance)?.remove_NotificationReceived(_notificationReceivedToken);
        }

        if (_saveAsUIShowing != null)
        {
            _saveAsUIShowing = null;
            WebView2Utilities.GetInterface<ICoreWebView2_25>(_instance)?.remove_SaveAsUIShowing(_saveAsUIShowingToken);
        }

        if (_saveFileSecurityCheckStarting != null)
        {
            _saveFileSecurityCheckStarting = null;
            WebView2Utilities.GetInterface<ICoreWebView2_26>(_instance)?.remove_SaveFileSecurityCheckStarting(_saveFileSecurityCheckStartingToken);
        }

        if (_screenCaptureStarting != null)
        {
            _screenCaptureStarting = null;
            WebView2Utilities.GetInterface<ICoreWebView2_27>(_instance)?.remove_ScreenCaptureStarting(_screenCaptureStartingToken);
        }

        if (_dedicatedWorkerCreated != null)
        {
            _dedicatedWorkerCreated = null;
            WebView2Utilities.GetInterface<ICoreWebView2_29>(_instance)?.remove_DedicatedWorkerCreated(_dedicatedWorkerCreatedToken);
        }
    }
}
