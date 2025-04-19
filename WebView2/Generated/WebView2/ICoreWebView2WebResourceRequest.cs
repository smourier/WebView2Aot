#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("97055cd4-512c-4264-8b5f-e3f446cea6a5")]
public partial interface ICoreWebView2WebResourceRequest
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Uri(ref PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Uri(PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Method(ref PWSTR method);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Method(PWSTR method);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Content(out IStream content);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Content(IStream content);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Headers([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpRequestHeaders>))] out ICoreWebView2HttpRequestHeaders headers);
}
