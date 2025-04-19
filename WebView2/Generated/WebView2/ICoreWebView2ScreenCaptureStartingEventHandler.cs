#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e24ff05a-1db5-59d9-89f3-3c864268db4a")]
public partial interface ICoreWebView2ScreenCaptureStartingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ScreenCaptureStartingEventArgs>))] ICoreWebView2ScreenCaptureStartingEventArgs args);
}
