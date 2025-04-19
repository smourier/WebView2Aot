#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4a5c436e-a9e3-4a2e-89c3-910d3513f5cc")]
public partial interface ICoreWebView2EnvironmentOptions3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsCustomCrashReportingEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsCustomCrashReportingEnabled(BOOL value);
}
