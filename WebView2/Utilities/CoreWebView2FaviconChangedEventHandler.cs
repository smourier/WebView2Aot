namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FaviconChangedEventHandler(Action<ICoreWebView2, IUnknown> handler)
    : ICoreWebView2FaviconChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
