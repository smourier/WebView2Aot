namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ExecuteScriptCompletedHandler(Action<HRESULT, PWSTR> handler)
    : ICoreWebView2ExecuteScriptCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, PWSTR result)
    {
        handler(errorCode, result);
        return 0;
    }
}
