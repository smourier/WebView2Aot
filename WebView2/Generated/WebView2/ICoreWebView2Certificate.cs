﻿#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c5fb2fce-1cac-4aee-9c79-5ed0362eaae0")]
public partial interface ICoreWebView2Certificate
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
}
