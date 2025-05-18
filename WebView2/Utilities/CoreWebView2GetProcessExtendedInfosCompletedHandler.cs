namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2GetProcessExtendedInfosCompletedHandler(Action<HRESULT, ICoreWebView2ProcessExtendedInfoCollection> handler)
    : ICoreWebView2GetProcessExtendedInfosCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2ProcessExtendedInfoCollection result)
    {
        handler(errorCode, result);
        return 0;
    }
}
