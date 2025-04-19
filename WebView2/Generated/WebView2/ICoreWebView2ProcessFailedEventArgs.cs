#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8155a9a4-1474-4a86-8cae-151b0fa6b8ca")]
public partial interface ICoreWebView2ProcessFailedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProcessFailedKind(ref COREWEBVIEW2_PROCESS_FAILED_KIND value);
}
