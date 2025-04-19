#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("12aae616-8ccb-44ec-bcb3-eb1831881635")]
public partial interface ICoreWebView2ControllerOptions
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProfileName(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ProfileName(PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsInPrivateModeEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsInPrivateModeEnabled(BOOL value);
}
