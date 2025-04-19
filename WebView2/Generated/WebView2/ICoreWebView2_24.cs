#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("39a7ad55-4287-5cc1-88a1-c6f458593824")]
public partial interface ICoreWebView2_24 : ICoreWebView2_23
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NotificationReceived([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NotificationReceivedEventHandler>))] ICoreWebView2NotificationReceivedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NotificationReceived(EventRegistrationToken token);
}
