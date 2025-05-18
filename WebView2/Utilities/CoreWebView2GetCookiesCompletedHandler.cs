namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2GetCookiesCompletedHandler(Action<HRESULT, ICoreWebView2CookieList> handler)
    : ICoreWebView2GetCookiesCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2CookieList result)
    {
        handler(errorCode, result);
        return 0;
    }
}
