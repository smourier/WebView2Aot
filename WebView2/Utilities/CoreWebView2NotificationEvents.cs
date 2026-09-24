namespace WebView2.Utilities;

public sealed class CoreWebView2NotificationEvents(ICoreWebView2Notification instance) : IDisposable
{
    private readonly ICoreWebView2Notification _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _closeRequested;
    private EventRegistrationToken _closeRequestedToken;

    public CoreWebView2NotificationEvents(IComObject<ICoreWebView2Notification> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2Notification Instance => _instance;

    public event EventHandler? CloseRequested
    {
        add
        {
            if (_closeRequested == null)
            {
                _instance.add_CloseRequested(new CoreWebView2NotificationCloseRequestedEventHandler((sender, args) => _closeRequested?.Invoke(sender, EventArgs.Empty)), ref _closeRequestedToken).ThrowOnError();
            }

            _closeRequested += value;
        }
        remove
        {
            _closeRequested -= value;
            if (_closeRequested == null)
            {
                _instance.remove_CloseRequested(_closeRequestedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_closeRequested != null)
        {
            _closeRequested = null;
            _instance.remove_CloseRequested(_closeRequestedToken);
        }
    }
}
