namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler(Action<HRESULT, ICoreWebView2CompositionController> handler)
    : ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler
{
    public HRESULT Invoke(HRESULT result, ICoreWebView2CompositionController controller)
    {
        handler(result, controller);
        return 0;
    }
}
