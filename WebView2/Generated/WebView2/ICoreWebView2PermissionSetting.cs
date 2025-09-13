#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("792b6eca-5576-421c-9119-74ebb3a4ffb3")]
public partial interface ICoreWebView2PermissionSetting
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PermissionKind(ref COREWEBVIEW2_PERMISSION_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PermissionOrigin(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PermissionState(ref COREWEBVIEW2_PERMISSION_STATE value);
}
