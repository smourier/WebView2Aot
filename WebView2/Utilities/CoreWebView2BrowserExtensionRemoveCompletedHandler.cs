namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2BrowserExtensionRemoveCompletedHandler(Action<HRESULT> handler)
    : ICoreWebView2BrowserExtensionRemoveCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode)
    {
        handler(errorCode);
        return 0;
    }
}
