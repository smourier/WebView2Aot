#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8f4ae680-192e-4ec8-833a-21cfadaef628")]
public partial interface ICoreWebView2Profile4 : ICoreWebView2Profile3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPermissionState(COREWEBVIEW2_PERMISSION_KIND PermissionKind, PWSTR origin, COREWEBVIEW2_PERMISSION_STATE State, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SetPermissionStateCompletedHandler>))] ICoreWebView2SetPermissionStateCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNonDefaultPermissionSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler>))] ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler handler);
}
