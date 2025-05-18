namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProfileDeletedEventHandler(Action<ICoreWebView2Profile, IUnknown> handler)
    : ICoreWebView2ProfileDeletedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Profile sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
