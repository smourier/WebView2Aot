#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ef05516f-d897-4f9e-b672-d8e2307a3fb0")]
public partial interface ICoreWebView2BasicAuthenticationRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Uri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Challenge(out PWSTR challenge);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Response([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BasicAuthenticationResponse>))] out ICoreWebView2BasicAuthenticationResponse response);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cancel(ref BOOL cancel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Cancel(BOOL cancel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
}
