namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProcessInfosChangedEventHandler(Action<ICoreWebView2Environment, IUnknown> handler)
    : ICoreWebView2ProcessInfosChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Environment sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
