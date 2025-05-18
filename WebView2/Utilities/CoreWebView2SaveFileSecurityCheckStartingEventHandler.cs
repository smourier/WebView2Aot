namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SaveFileSecurityCheckStartingEventHandler(Action<ICoreWebView2, ICoreWebView2SaveFileSecurityCheckStartingEventArgs> handler)
    : ICoreWebView2SaveFileSecurityCheckStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2SaveFileSecurityCheckStartingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
