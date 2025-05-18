namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NewBrowserVersionAvailableEventHandler(Action<ICoreWebView2Environment, IUnknown> handler)
    : ICoreWebView2NewBrowserVersionAvailableEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Environment sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
