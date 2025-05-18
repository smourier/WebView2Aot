namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DocumentTitleChangedEventHandler(Action<ICoreWebView2, IUnknown> handler)
    : ICoreWebView2DocumentTitleChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
