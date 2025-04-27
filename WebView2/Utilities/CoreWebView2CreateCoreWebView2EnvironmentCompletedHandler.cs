namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler(Action<HRESULT, ICoreWebView2Environment> handler)
    : ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
{
    public HRESULT Invoke(HRESULT result, ICoreWebView2Environment environment)
    {
        handler(result, environment);
        return 0;
    }
}
