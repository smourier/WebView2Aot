namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler(Action<HRESULT, ICoreWebView2CompositionController> handler)
    : ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2CompositionController result)
    {
        handler(errorCode, result);
        return 0;
    }
}
