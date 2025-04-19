#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("aafcc94f-fa27-48fd-97df-830ef75aaec9")]
public partial interface ICoreWebView2WebResourceResponse
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Content(out IStream content);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Content(IStream content);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Headers([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpResponseHeaders>))] out ICoreWebView2HttpResponseHeaders headers);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StatusCode(ref int statusCode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StatusCode(int statusCode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReasonPhrase(ref PWSTR reasonPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ReasonPhrase(PWSTR reasonPhrase);
}
