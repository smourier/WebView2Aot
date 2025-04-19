#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a6c1d8ad-bb80-59c5-895b-fba1698b9309")]
public partial interface ICoreWebView2FrameScreenCaptureStartingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ScreenCaptureStartingEventArgs>))] ICoreWebView2ScreenCaptureStartingEventArgs args);
}
