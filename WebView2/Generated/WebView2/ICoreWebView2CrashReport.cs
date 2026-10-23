#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("74128fe8-5080-5f46-941d-fb747b0bcd62")]
public partial interface ICoreWebView2CrashReport
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BucketId(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CrashReportId(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExceptionCode(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FaultOffset(ref ulong value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FaultingModuleName(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FaultingModuleVersion(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReportTime(ref ulong value);
}
