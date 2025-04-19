#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("00f206a7-9d17-4605-91f6-4e8e4de192e3")]
public partial interface ICoreWebView2TrySuspendCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, BOOL result);
}
