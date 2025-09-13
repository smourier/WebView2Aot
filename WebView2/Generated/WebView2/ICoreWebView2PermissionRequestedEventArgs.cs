#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("973ae2ef-ff18-4894-8fb2-3c758f046810")]
public partial interface ICoreWebView2PermissionRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Uri(out PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PermissionKind(ref COREWEBVIEW2_PERMISSION_KIND permissionKind);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsUserInitiated(ref BOOL isUserInitiated);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(ref COREWEBVIEW2_PERMISSION_STATE state);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_State(COREWEBVIEW2_PERMISSION_STATE state);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
}
