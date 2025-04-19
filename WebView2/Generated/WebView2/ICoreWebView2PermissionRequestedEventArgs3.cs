#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e61670bc-3dce-4177-86d2-c629ae3cb6ac")]
public partial interface ICoreWebView2PermissionRequestedEventArgs3 : ICoreWebView2PermissionRequestedEventArgs2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SavesInProfile(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SavesInProfile(BOOL value);
}
