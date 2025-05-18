namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProcessFailedEventHandler(Action<ICoreWebView2, ICoreWebView2ProcessFailedEventArgs> handler)
    : ICoreWebView2ProcessFailedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ProcessFailedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
