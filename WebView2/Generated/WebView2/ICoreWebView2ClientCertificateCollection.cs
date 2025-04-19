#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ef5674d2-bcc3-11eb-8529-0242ac130003")]
public partial interface ICoreWebView2ClientCertificateCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClientCertificate>))] out ICoreWebView2ClientCertificate value);
}
