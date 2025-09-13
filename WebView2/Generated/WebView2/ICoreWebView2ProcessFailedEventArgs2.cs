#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4dab9422-46fa-4c3e-a5d2-41d2071d3680")]
public partial interface ICoreWebView2ProcessFailedEventArgs2 : ICoreWebView2ProcessFailedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Reason(ref COREWEBVIEW2_PROCESS_FAILED_REASON reason);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExitCode(ref int exitCode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProcessDescription(out PWSTR processDescription);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrameInfosForFailedProcess([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfoCollection>))] out ICoreWebView2FrameInfoCollection frames);
}
