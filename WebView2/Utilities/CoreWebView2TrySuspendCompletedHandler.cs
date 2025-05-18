namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2TrySuspendCompletedHandler(Action<HRESULT, BOOL> handler)
    : ICoreWebView2TrySuspendCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, BOOL result)
    {
        handler(errorCode, result);
        return 0;
    }
}
