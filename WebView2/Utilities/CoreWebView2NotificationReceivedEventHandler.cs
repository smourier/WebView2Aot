namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NotificationReceivedEventHandler(Action<ICoreWebView2, ICoreWebView2NotificationReceivedEventArgs> handler)
    : ICoreWebView2NotificationReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2NotificationReceivedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
