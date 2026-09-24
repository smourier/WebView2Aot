namespace WebView2.Utilities;

public sealed class CoreWebView2SharedWorkerEvents(ICoreWebView2SharedWorker instance) : IDisposable
{
    private readonly ICoreWebView2SharedWorker _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _destroying;
    private EventRegistrationToken _destroyingToken;

    public CoreWebView2SharedWorkerEvents(IComObject<ICoreWebView2SharedWorker> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2SharedWorker Instance => _instance;

    public event EventHandler? Destroying
    {
        add
        {
            if (_destroying == null)
            {
                _instance.add_Destroying(new CoreWebView2SharedWorkerDestroyingEventHandler((sender, args) => _destroying?.Invoke(sender, EventArgs.Empty)), ref _destroyingToken).ThrowOnError();
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

    public void Dispose()
    {
        if (_destroying != null)
        {
            _destroying = null;
            _instance.remove_Destroying(_destroyingToken);
        }
    }
}
