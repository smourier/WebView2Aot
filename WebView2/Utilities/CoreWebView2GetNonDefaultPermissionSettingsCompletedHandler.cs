namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler(Action<HRESULT, ICoreWebView2PermissionSettingCollectionView> handler)
    : ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2PermissionSettingCollectionView result)
    {
        handler(errorCode, result);
        return 0;
    }
}
