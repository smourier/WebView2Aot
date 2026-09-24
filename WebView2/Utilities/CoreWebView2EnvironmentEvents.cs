namespace WebView2.Utilities;

public sealed class CoreWebView2EnvironmentEvents(ICoreWebView2Environment instance) : IDisposable
{
    private readonly ICoreWebView2Environment _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _newBrowserVersionAvailable;
    private EventRegistrationToken _newBrowserVersionAvailableToken;
    private EventHandler<ICoreWebView2BrowserProcessExitedEventArgs>? _browserProcessExited;
    private EventRegistrationToken _browserProcessExitedToken;
    private EventHandler? _processInfosChanged;
    private EventRegistrationToken _processInfosChangedToken;

    public CoreWebView2EnvironmentEvents(IComObject<ICoreWebView2Environment> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2Environment Instance => _instance;

    public event EventHandler? NewBrowserVersionAvailable
    {
        add
        {
            if (_newBrowserVersionAvailable == null)
            {
                _instance.add_NewBrowserVersionAvailable(new CoreWebView2NewBrowserVersionAvailableEventHandler((sender, args) => _newBrowserVersionAvailable?.Invoke(sender, EventArgs.Empty)), ref _newBrowserVersionAvailableToken).ThrowOnError();
            }

            _newBrowserVersionAvailable += value;
        }
        remove
        {
            _newBrowserVersionAvailable -= value;
            if (_newBrowserVersionAvailable == null)
            {
                _instance.remove_NewBrowserVersionAvailable(_newBrowserVersionAvailableToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment5"/>.</remarks>
    public event EventHandler<ICoreWebView2BrowserProcessExitedEventArgs>? BrowserProcessExited
    {
        add
        {
            if (_browserProcessExited == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Environment5>(_instance) is not { } typed)
                    return;

                typed.add_BrowserProcessExited(new CoreWebView2BrowserProcessExitedEventHandler((sender, args) => _browserProcessExited?.Invoke(sender, args)), ref _browserProcessExitedToken).ThrowOnError();
            }

            _browserProcessExited += value;
        }
        remove
        {
            _browserProcessExited -= value;
            if (_browserProcessExited == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Environment5>(_instance)?.remove_BrowserProcessExited(_browserProcessExitedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment8"/>.</remarks>
    public event EventHandler? ProcessInfosChanged
    {
        add
        {
            if (_processInfosChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Environment8>(_instance) is not { } typed)
                    return;

                typed.add_ProcessInfosChanged(new CoreWebView2ProcessInfosChangedEventHandler((sender, args) => _processInfosChanged?.Invoke(sender, EventArgs.Empty)), ref _processInfosChangedToken).ThrowOnError();
            }

            _processInfosChanged += value;
        }
        remove
        {
            _processInfosChanged -= value;
            if (_processInfosChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Environment8>(_instance)?.remove_ProcessInfosChanged(_processInfosChangedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_newBrowserVersionAvailable != null)
        {
            _newBrowserVersionAvailable = null;
            _instance.remove_NewBrowserVersionAvailable(_newBrowserVersionAvailableToken);
        }

        if (_browserProcessExited != null)
        {
            _browserProcessExited = null;
            WebView2Utilities.GetInterface<ICoreWebView2Environment5>(_instance)?.remove_BrowserProcessExited(_browserProcessExitedToken);
        }

        if (_processInfosChanged != null)
        {
            _processInfosChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2Environment8>(_instance)?.remove_ProcessInfosChanged(_processInfosChangedToken);
        }
    }
}
