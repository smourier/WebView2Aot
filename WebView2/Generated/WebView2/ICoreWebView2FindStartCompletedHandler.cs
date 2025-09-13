#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("6a90ecaf-44b0-5bd9-8f07-1967e17be9fb")]
public partial interface ICoreWebView2FindStartCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode);
}
