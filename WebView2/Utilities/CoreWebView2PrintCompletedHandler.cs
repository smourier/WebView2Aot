namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2PrintCompletedHandler(Action<HRESULT, COREWEBVIEW2_PRINT_STATUS> handler)
    : ICoreWebView2PrintCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, COREWEBVIEW2_PRINT_STATUS result)
    {
        handler(errorCode, result);
        return 0;
    }
}
