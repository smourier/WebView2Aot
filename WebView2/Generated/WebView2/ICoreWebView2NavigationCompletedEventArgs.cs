#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("30d68b7d-20d9-4752-a9ca-ec8448fbb5c1")]
public partial interface ICoreWebView2NavigationCompletedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsSuccess(ref BOOL isSuccess);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WebErrorStatus(ref COREWEBVIEW2_WEB_ERROR_STATUS webErrorStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NavigationId(ref ulong navigationId);
}
