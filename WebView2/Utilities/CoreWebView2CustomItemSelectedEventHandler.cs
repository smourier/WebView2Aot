namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CustomItemSelectedEventHandler(Action<ICoreWebView2ContextMenuItem, IUnknown> handler)
    : ICoreWebView2CustomItemSelectedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ContextMenuItem sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
