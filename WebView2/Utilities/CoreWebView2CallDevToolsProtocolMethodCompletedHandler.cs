namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CallDevToolsProtocolMethodCompletedHandler(Action<HRESULT, PWSTR> handler)
    : ICoreWebView2CallDevToolsProtocolMethodCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, PWSTR result)
    {
        handler(errorCode, result);
        return 0;
    }
}
