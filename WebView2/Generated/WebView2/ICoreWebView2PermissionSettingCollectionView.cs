#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f5596f62-3de5-47b1-91e8-a4104b596b96")]
public partial interface ICoreWebView2PermissionSettingCollectionView
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PermissionSetting>))] out ICoreWebView2PermissionSetting permissionSetting);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
}
