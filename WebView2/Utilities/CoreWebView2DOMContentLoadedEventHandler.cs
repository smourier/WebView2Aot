namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DOMContentLoadedEventHandler(Action<ICoreWebView2, ICoreWebView2DOMContentLoadedEventArgs> handler)
    : ICoreWebView2DOMContentLoadedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2DOMContentLoadedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
