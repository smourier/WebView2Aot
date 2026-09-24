namespace WebView2.Utilities;

public sealed class CoreWebView2SharedWorkerManagerEvents(ICoreWebView2SharedWorkerManager instance) : IDisposable
{
    private readonly ICoreWebView2SharedWorkerManager _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler<ICoreWebView2SharedWorkerCreatedEventArgs>? _sharedWorkerCreated;
    private EventRegistrationToken _sharedWorkerCreatedToken;

    public CoreWebView2SharedWorkerManagerEvents(IComObject<ICoreWebView2SharedWorkerManager> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2SharedWorkerManager Instance => _instance;

    public event EventHandler<ICoreWebView2SharedWorkerCreatedEventArgs>? SharedWorkerCreated
    {
        add
        {
            if (_sharedWorkerCreated == null)
            {
                _instance.add_SharedWorkerCreated(new CoreWebView2SharedWorkerCreatedEventHandler((sender, args) => _sharedWorkerCreated?.Invoke(sender, args)), ref _sharedWorkerCreatedToken).ThrowOnError();
            }

            _sharedWorkerCreated += value;
        }
        remove
        {
            _sharedWorkerCreated -= value;
            if (_sharedWorkerCreated == null)
            {
                _instance.remove_SharedWorkerCreated(_sharedWorkerCreatedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_sharedWorkerCreated != null)
        {
            _sharedWorkerCreated = null;
            _instance.remove_SharedWorkerCreated(_sharedWorkerCreatedToken);
        }
    }
}
