namespace WebView2.Utilities;

public sealed class CoreWebView2ServiceWorkerEvents(ICoreWebView2ServiceWorker instance) : IDisposable
{
    private readonly ICoreWebView2ServiceWorker _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _destroying;
    private EventRegistrationToken _destroyingToken;
    private EventHandler<ICoreWebView2WebMessageReceivedEventArgs>? _webMessageReceived;
    private EventRegistrationToken _webMessageReceivedToken;

    public CoreWebView2ServiceWorkerEvents(IComObject<ICoreWebView2ServiceWorker> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2ServiceWorker Instance => _instance;

    public event EventHandler? Destroying
    {
        add
        {
            if (_destroying == null)
            {
                _instance.add_Destroying(new CoreWebView2ServiceWorkerDestroyingEventHandler((sender, args) => _destroying?.Invoke(sender, EventArgs.Empty)), ref _destroyingToken).ThrowOnError();
            }

            _destroying += value;
        }
        remove
        {
            _destroying -= value;
            if (_destroying == null)
            {
                _instance.remove_Destroying(_destroyingToken);
            }
        }
    }

    public event EventHandler<ICoreWebView2WebMessageReceivedEventArgs>? WebMessageReceived
    {
        add
        {
            if (_webMessageReceived == null)
            {
                _instance.add_WebMessageReceived(new CoreWebView2ServiceWorkerWebMessageReceivedEventHandler((sender, args) => _webMessageReceived?.Invoke(sender, args)), ref _webMessageReceivedToken).ThrowOnError();
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

    public void Dispose()
    {
        if (_destroying != null)
        {
            _destroying = null;
            _instance.remove_Destroying(_destroyingToken);
        }

        if (_webMessageReceived != null)
        {
            _webMessageReceived = null;
            _instance.remove_WebMessageReceived(_webMessageReceivedToken);
        }
    }
}
