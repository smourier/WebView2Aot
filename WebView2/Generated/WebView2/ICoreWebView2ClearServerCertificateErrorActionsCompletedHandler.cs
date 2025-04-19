#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3b40aac6-acfe-4ffd-8211-f607b96e2d5b")]
public partial interface ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode);
}
