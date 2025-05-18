namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2BrowserExtensionEnableCompletedHandler(Action<HRESULT> handler)
    : ICoreWebView2BrowserExtensionEnableCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode)
    {
        handler(errorCode);
        return 0;
    }
}
