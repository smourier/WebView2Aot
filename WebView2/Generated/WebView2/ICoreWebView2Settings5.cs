#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("183e7052-1d03-43a0-ab99-98e043b66b39")]
public partial interface ICoreWebView2Settings5 : ICoreWebView2Settings4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsPinchZoomEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsPinchZoomEnabled(BOOL value);
}
