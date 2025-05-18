namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler(Action<HRESULT, PWSTR> handler)
    : ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, PWSTR result)
    {
        handler(errorCode, result);
        return 0;
    }
}
