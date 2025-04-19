#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("57d29cc3-c84f-42a0-b0e2-effbd5e179de")]
public partial interface ICoreWebView2EnvironmentOptions6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AreBrowserExtensionsEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AreBrowserExtensionsEnabled(BOOL value);
}
