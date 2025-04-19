#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e9710a06-1d1d-49b2-8234-226f35846ae5")]
public partial interface ICoreWebView2ClearBrowsingDataCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode);
}
