namespace WebView2.Utilities;

public sealed class CoreWebView2DevToolsProtocolEventReceiverEvents(ICoreWebView2DevToolsProtocolEventReceiver instance) : IDisposable
{
    private readonly ICoreWebView2DevToolsProtocolEventReceiver _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler<ICoreWebView2DevToolsProtocolEventReceivedEventArgs>? _devToolsProtocolEventReceived;
    private EventRegistrationToken _devToolsProtocolEventReceivedToken;

    public CoreWebView2DevToolsProtocolEventReceiverEvents(IComObject<ICoreWebView2DevToolsProtocolEventReceiver> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2DevToolsProtocolEventReceiver Instance => _instance;

    public event EventHandler<ICoreWebView2DevToolsProtocolEventReceivedEventArgs>? DevToolsProtocolEventReceived
    {
        add
        {
            if (_devToolsProtocolEventReceived == null)
            {
                _instance.add_DevToolsProtocolEventReceived(new CoreWebView2DevToolsProtocolEventReceivedEventHandler((sender, args) => _devToolsProtocolEventReceived?.Invoke(sender, args)), ref _devToolsProtocolEventReceivedToken).ThrowOnError();
            }

            _devToolsProtocolEventReceived += value;
        }
        remove
        {
            _devToolsProtocolEventReceived -= value;
            if (_devToolsProtocolEventReceived == null)
            {
                _instance.remove_DevToolsProtocolEventReceived(_devToolsProtocolEventReceivedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_devToolsProtocolEventReceived != null)
        {
            _devToolsProtocolEventReceived = null;
            _instance.remove_DevToolsProtocolEventReceived(_devToolsProtocolEventReceivedToken);
        }
    }
}
