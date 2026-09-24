namespace WebView2.Utilities;

public sealed class CoreWebView2DedicatedWorkerEvents(ICoreWebView2DedicatedWorker instance) : IDisposable
{
    private readonly ICoreWebView2DedicatedWorker _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler<ICoreWebView2DedicatedWorkerCreatedEventArgs>? _dedicatedWorkerCreated;
    private EventRegistrationToken _dedicatedWorkerCreatedToken;
    private EventHandler? _destroying;
    private EventRegistrationToken _destroyingToken;
    private EventHandler<ICoreWebView2WebMessageReceivedEventArgs>? _webMessageReceived;
    private EventRegistrationToken _webMessageReceivedToken;

    public CoreWebView2DedicatedWorkerEvents(IComObject<ICoreWebView2DedicatedWorker> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2DedicatedWorker Instance => _instance;

    public event EventHandler<ICoreWebView2DedicatedWorkerCreatedEventArgs>? DedicatedWorkerCreated
    {
        add
        {
            if (_dedicatedWorkerCreated == null)
            {
                _instance.add_DedicatedWorkerCreated(new CoreWebView2DedicatedWorkerDedicatedWorkerCreatedEventHandler((sender, args) => _dedicatedWorkerCreated?.Invoke(sender, args)), ref _dedicatedWorkerCreatedToken).ThrowOnError();
            }

            _dedicatedWorkerCreated += value;
        }
        remove
        {
            _dedicatedWorkerCreated -= value;
            if (_dedicatedWorkerCreated == null)
            {
                _instance.remove_DedicatedWorkerCreated(_dedicatedWorkerCreatedToken);
            }
        }
    }

    public event EventHandler? Destroying
    {
        add
        {
            if (_destroying == null)
            {
                _instance.add_Destroying(new CoreWebView2DedicatedWorkerDestroyingEventHandler((sender, args) => _destroying?.Invoke(sender, EventArgs.Empty)), ref _destroyingToken).ThrowOnError();
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
                _instance.add_WebMessageReceived(new CoreWebView2DedicatedWorkerWebMessageReceivedEventHandler((sender, args) => _webMessageReceived?.Invoke(sender, args)), ref _webMessageReceivedToken).ThrowOnError();
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
        if (_dedicatedWorkerCreated != null)
        {
            _dedicatedWorkerCreated = null;
            _instance.remove_DedicatedWorkerCreated(_dedicatedWorkerCreatedToken);
        }

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
