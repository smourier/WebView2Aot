#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("6daa4f10-4a90-4753-8898-77c5df534165")]
public partial interface ICoreWebView2_14 : ICoreWebView2_13
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ServerCertificateErrorDetected([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServerCertificateErrorDetectedEventHandler>))] ICoreWebView2ServerCertificateErrorDetectedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ServerCertificateErrorDetected(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearServerCertificateErrorActions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler>))] ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler);
}
