#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3598cfa2-d85d-5a9f-9228-4dde1f59ec64")]
public partial interface ICoreWebView2Frame7 : ICoreWebView2Frame6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_FrameCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameChildFrameCreatedEventHandler>))] ICoreWebView2FrameChildFrameCreatedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_FrameCreated(EventRegistrationToken token);
}
