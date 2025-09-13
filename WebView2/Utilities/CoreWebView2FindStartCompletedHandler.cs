namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FindStartCompletedHandler(Action<HRESULT> handler)
    : ICoreWebView2FindStartCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode)
    {
        handler(errorCode);
        return 0;
    }
}
