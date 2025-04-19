#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("07023f7d-2d77-4d67-9040-6e7d428c6a40")]
public partial interface ICoreWebView2BasicAuthenticationResponse
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserName(ref PWSTR userName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UserName(PWSTR userName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Password(ref PWSTR password);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Password(PWSTR password);
}
