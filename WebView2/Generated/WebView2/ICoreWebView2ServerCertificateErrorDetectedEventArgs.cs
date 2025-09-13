#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("012193ed-7c13-48ff-969d-a84c1f432a14")]
public partial interface ICoreWebView2ServerCertificateErrorDetectedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ErrorStatus(ref COREWEBVIEW2_WEB_ERROR_STATUS value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequestUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ServerCertificate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Certificate>))] out ICoreWebView2Certificate value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Action(ref COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Action(COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
}
