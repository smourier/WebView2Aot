#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("2fde08a8-1e9a-4766-8c05-95a9ceb9d1c5")]
public partial interface ICoreWebView2EnvironmentOptions
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AdditionalBrowserArguments(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AdditionalBrowserArguments(PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Language(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Language(PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TargetCompatibleBrowserVersion(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TargetCompatibleBrowserVersion(PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowSingleSignOnUsingOSPrimaryAccount(ref BOOL allow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowSingleSignOnUsingOSPrimaryAccount(BOOL allow);
}
