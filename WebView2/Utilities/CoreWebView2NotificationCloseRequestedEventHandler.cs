namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NotificationCloseRequestedEventHandler(Action<ICoreWebView2Notification, IUnknown> handler)
    : ICoreWebView2NotificationCloseRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Notification sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
