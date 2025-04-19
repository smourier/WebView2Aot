#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a2508329-7da8-49d7-8c05-fa125e4aee8d")]
public partial interface ICoreWebView2GetFaviconCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, IStream result);
}
