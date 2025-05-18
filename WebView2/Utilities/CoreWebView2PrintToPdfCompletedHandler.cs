namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2PrintToPdfCompletedHandler(Action<HRESULT, BOOL> handler)
    : ICoreWebView2PrintToPdfCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, BOOL result)
    {
        handler(errorCode, result);
        return 0;
    }
}
