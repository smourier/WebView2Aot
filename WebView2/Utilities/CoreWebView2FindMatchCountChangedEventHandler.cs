namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FindMatchCountChangedEventHandler(Action<ICoreWebView2Find, IUnknown> handler)
    : ICoreWebView2FindMatchCountChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Find sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
