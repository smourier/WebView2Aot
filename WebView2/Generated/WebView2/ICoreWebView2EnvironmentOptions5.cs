#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0ae35d64-c47f-4464-814e-259c345d1501")]
public partial interface ICoreWebView2EnvironmentOptions5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnableTrackingPrevention(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableTrackingPrevention(BOOL value);
}
