#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ccf1ef04-fd8e-4d5f-b2de-0983e41b8c36")]
public partial interface ICoreWebView2PrintToPdfCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, BOOL result);
}
