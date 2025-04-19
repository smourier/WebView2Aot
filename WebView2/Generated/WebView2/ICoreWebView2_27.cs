#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("00fbe33b-8c07-517c-aa23-0ddd4b5f6fa0")]
public partial interface ICoreWebView2_27 : ICoreWebView2_26
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ScreenCaptureStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ScreenCaptureStartingEventHandler>))] ICoreWebView2ScreenCaptureStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ScreenCaptureStarting(EventRegistrationToken token);
}
