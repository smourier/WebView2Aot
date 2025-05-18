namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ClearServerCertificateErrorActionsCompletedHandler(Action<HRESULT> handler)
    : ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode)
    {
        handler(errorCode);
        return 0;
    }
}
