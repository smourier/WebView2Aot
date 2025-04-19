#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c5fb2fce-1cac-4aee-9c79-5ed0362eaae0")]
public partial interface ICoreWebView2Certificate
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Subject(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Issuer(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ValidFrom(ref double value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ValidTo(ref double value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DerEncodedSerialNumber(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisplayName(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ToPemEncoding(ref PWSTR pemEncodedData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PemEncodedIssuerCertificateChain([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2StringCollection>))] out ICoreWebView2StringCollection value);
}
