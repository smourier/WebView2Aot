namespace WebView2.Utilities;

public sealed class CoreWebView2ServiceWorkerManagerEvents(ICoreWebView2ServiceWorkerManager instance) : IDisposable
{
    private readonly ICoreWebView2ServiceWorkerManager _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler<ICoreWebView2ServiceWorkerRegisteredEventArgs>? _serviceWorkerRegistered;
    private EventRegistrationToken _serviceWorkerRegisteredToken;

    public CoreWebView2ServiceWorkerManagerEvents(IComObject<ICoreWebView2ServiceWorkerManager> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2ServiceWorkerManager Instance => _instance;

    public event EventHandler<ICoreWebView2ServiceWorkerRegisteredEventArgs>? ServiceWorkerRegistered
    {
        add
        {
            if (_serviceWorkerRegistered == null)
            {
                _instance.add_ServiceWorkerRegistered(new CoreWebView2ServiceWorkerRegisteredEventHandler((sender, args) => _serviceWorkerRegistered?.Invoke(sender, args)), ref _serviceWorkerRegisteredToken).ThrowOnError();
            }

            _serviceWorkerRegistered += value;
        }
        remove
        {
            _serviceWorkerRegistered -= value;
            if (_serviceWorkerRegistered == null)
            {
                _instance.remove_ServiceWorkerRegistered(_serviceWorkerRegisteredToken);
            }
        }
    }

    public void Dispose()
    {
        if (_serviceWorkerRegistered != null)
        {
            _serviceWorkerRegistered = null;
            _instance.remove_ServiceWorkerRegistered(_serviceWorkerRegisteredToken);
        }
    }
}
