namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2GetSharedWorkersCompletedHandler(Action<HRESULT, ICoreWebView2SharedWorkerCollectionView> handler)
    : ICoreWebView2GetSharedWorkersCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2SharedWorkerCollectionView result)
    {
        handler(errorCode, result);
        return 0;
    }
}
