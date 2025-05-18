namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SetPermissionStateCompletedHandler(Action<HRESULT> handler)
    : ICoreWebView2SetPermissionStateCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode)
    {
        handler(errorCode);
        return 0;
    }
}
