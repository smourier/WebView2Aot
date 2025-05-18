namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProfileAddBrowserExtensionCompletedHandler(Action<HRESULT, ICoreWebView2BrowserExtension> handler)
    : ICoreWebView2ProfileAddBrowserExtensionCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2BrowserExtension result)
    {
        handler(errorCode, result);
        return 0;
    }
}
