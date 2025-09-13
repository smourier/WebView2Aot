#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("bc59db28-bcc3-11eb-8529-0242ac130003")]
public partial interface ICoreWebView2ClientCertificateRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Host(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Port(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsProxy(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowedCertificateAuthorities([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2StringCollection>))] out ICoreWebView2StringCollection value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MutuallyTrustedCertificates([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClientCertificateCollection>))] out ICoreWebView2ClientCertificateCollection value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SelectedCertificate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClientCertificate>))] out ICoreWebView2ClientCertificate value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SelectedCertificate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClientCertificate>))] ICoreWebView2ClientCertificate value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cancel(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Cancel(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
}
