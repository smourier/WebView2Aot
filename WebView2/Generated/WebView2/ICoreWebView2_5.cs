#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("bedb11b8-d63c-11eb-b8bc-0242ac130003")]
public partial interface ICoreWebView2_5 : ICoreWebView2_4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ClientCertificateRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClientCertificateRequestedEventHandler>))] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ClientCertificateRequested(EventRegistrationToken token);
}
