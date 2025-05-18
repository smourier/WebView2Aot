namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2LaunchingExternalUriSchemeEventHandler(Action<ICoreWebView2, ICoreWebView2LaunchingExternalUriSchemeEventArgs> handler)
    : ICoreWebView2LaunchingExternalUriSchemeEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2LaunchingExternalUriSchemeEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
