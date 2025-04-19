#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8e41909a-9b18-4bb1-8cdf-930f467a50be")]
public partial interface ICoreWebView2BrowserExtensionRemoveCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode);
}
