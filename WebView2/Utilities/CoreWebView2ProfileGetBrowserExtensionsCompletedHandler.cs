namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProfileGetBrowserExtensionsCompletedHandler(Action<HRESULT, ICoreWebView2BrowserExtensionList> handler)
    : ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2BrowserExtensionList result)
    {
        handler(errorCode, result);
        return 0;
    }
}
