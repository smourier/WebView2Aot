namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ExecuteScriptWithResultCompletedHandler(Action<HRESULT, ICoreWebView2ExecuteScriptResult> handler)
    : ICoreWebView2ExecuteScriptWithResultCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2ExecuteScriptResult result)
    {
        handler(errorCode, result);
        return 0;
    }
}
