#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("74d7127f-9de6-4200-8734-42d6fb4ff741")]
public partial interface ICoreWebView2PermissionRequestedEventArgs2 : ICoreWebView2PermissionRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL value);
}
