#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("84fa7612-3f3d-4fbf-889d-fad000492d72")]
public partial interface ICoreWebView2ProcessInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProcessId(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Kind(ref COREWEBVIEW2_PROCESS_KIND kind);
}
