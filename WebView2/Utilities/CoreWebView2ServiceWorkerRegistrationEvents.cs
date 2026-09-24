namespace WebView2.Utilities;

public sealed class CoreWebView2ServiceWorkerRegistrationEvents(ICoreWebView2ServiceWorkerRegistration instance) : IDisposable
{
    private readonly ICoreWebView2ServiceWorkerRegistration _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler<ICoreWebView2ServiceWorkerActivatedEventArgs>? _serviceWorkerActivated;
    private EventRegistrationToken _serviceWorkerActivatedToken;
    private EventHandler? _unregistering;
    private EventRegistrationToken _unregisteringToken;

    public CoreWebView2ServiceWorkerRegistrationEvents(IComObject<ICoreWebView2ServiceWorkerRegistration> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2ServiceWorkerRegistration Instance => _instance;

    public event EventHandler<ICoreWebView2ServiceWorkerActivatedEventArgs>? ServiceWorkerActivated
    {
        add
        {
            if (_serviceWorkerActivated == null)
            {
                _instance.add_ServiceWorkerActivated(new CoreWebView2ServiceWorkerActivatedEventHandler((sender, args) => _serviceWorkerActivated?.Invoke(sender, args)), ref _serviceWorkerActivatedToken).ThrowOnError();
            }

            _serviceWorkerActivated += value;
        }
        remove
        {
            _serviceWorkerActivated -= value;
            if (_serviceWorkerActivated == null)
            {
                _instance.remove_ServiceWorkerActivated(_serviceWorkerActivatedToken);
            }
        }
    }

    public event EventHandler? Unregistering
    {
        add
        {
            if (_unregistering == null)
            {
                _instance.add_Unregistering(new CoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler((sender, args) => _unregistering?.Invoke(sender, EventArgs.Empty)), ref _unregisteringToken).ThrowOnError();
            }

            _unregistering += value;
        }
        remove
        {
            _unregistering -= value;
            if (_unregistering == null)
            {
                _instance.remove_Unregistering(_unregisteringToken);
            }
        }
    }

    public void Dispose()
    {
        if (_serviceWorkerActivated != null)
        {
            _serviceWorkerActivated = null;
            _instance.remove_ServiceWorkerActivated(_serviceWorkerActivatedToken);
        }

        if (_unregistering != null)
        {
            _unregistering = null;
            _instance.remove_Unregistering(_unregisteringToken);
        }
    }
}
