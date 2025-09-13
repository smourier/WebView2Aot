﻿#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e7188076-bcc3-11eb-8529-0242ac130003")]
public partial interface ICoreWebView2ClientCertificate
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Subject(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Issuer(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ValidFrom(ref double value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ValidTo(ref double value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DerEncodedSerialNumber(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisplayName(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ToPemEncoding(out PWSTR pemEncodedData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PemEncodedIssuerCertificateChain([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2StringCollection>))] out ICoreWebView2StringCollection value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Kind(ref COREWEBVIEW2_CLIENT_CERTIFICATE_KIND value);
}
