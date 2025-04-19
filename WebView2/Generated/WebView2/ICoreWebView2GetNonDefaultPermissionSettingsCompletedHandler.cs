#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("38274481-a15c-4563-94cf-990edc9aeb95")]
public partial interface ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PermissionSettingCollectionView>))] ICoreWebView2PermissionSettingCollectionView result);
}
