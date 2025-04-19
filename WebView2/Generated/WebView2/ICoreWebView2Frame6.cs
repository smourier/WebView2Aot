#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0de611fd-31e9-5ddc-9d71-95eda26eff32")]
public partial interface ICoreWebView2Frame6 : ICoreWebView2Frame5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ScreenCaptureStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameScreenCaptureStartingEventHandler>))] ICoreWebView2FrameScreenCaptureStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ScreenCaptureStarting(EventRegistrationToken token);
}
