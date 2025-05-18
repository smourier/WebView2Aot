namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ClearBrowsingDataCompletedHandler(Action<HRESULT> handler)
    : ICoreWebView2ClearBrowsingDataCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode)
    {
        handler(errorCode);
        return 0;
    }
}
