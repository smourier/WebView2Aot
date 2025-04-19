namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler(Action<HRESULT, ICoreWebView2Environment> handler) : ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
{
    public HRESULT Invoke(HRESULT errorCode, ICoreWebView2Environment result)
    {
        handler(errorCode, result);
        return 0;
    }
}
