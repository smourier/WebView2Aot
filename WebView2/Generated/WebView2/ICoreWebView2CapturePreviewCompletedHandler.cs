#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("697e05e9-3d8f-45fa-96f4-8ffe1ededaf5")]
public partial interface ICoreWebView2CapturePreviewCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode);
}
