#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("969b3a26-d85e-4795-8199-fef57344da22")]
public partial interface ICoreWebView2ServerCertificateErrorDetectedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServerCertificateErrorDetectedEventArgs>))] ICoreWebView2ServerCertificateErrorDetectedEventArgs args);
}
