namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ContentLoadingEventHandler(Action<ICoreWebView2, ICoreWebView2ContentLoadingEventArgs> handler)
    : ICoreWebView2ContentLoadingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ContentLoadingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
