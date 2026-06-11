namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2GetServiceWorkerRegistrationsCompletedHandler(Action<HRESULT, ICoreWebView2ServiceWorkerRegistrationCollectionView> handler)
    : ICoreWebView2GetServiceWorkerRegistrationsCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2ServiceWorkerRegistrationCollectionView result)
    {
        handler(errorCode, result);
        return 0;
    }
}
