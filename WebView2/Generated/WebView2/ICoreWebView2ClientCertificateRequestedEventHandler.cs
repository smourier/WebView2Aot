#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("d7175ba2-bcc3-11eb-8529-0242ac130003")]
public partial interface ICoreWebView2ClientCertificateRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClientCertificateRequestedEventArgs>))] ICoreWebView2ClientCertificateRequestedEventArgs args);
}
