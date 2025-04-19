#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("6921f954-79b0-437f-a997-c85811897c68")]
public partial interface ICoreWebView2_19 : ICoreWebView2_18
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MemoryUsageTargetLevel(ref COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MemoryUsageTargetLevel(COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL value);
}
