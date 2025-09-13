#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("79701053-7759-4162-8f7d-f1b3f084928d")]
public partial interface ICoreWebView2WebResourceResponseView
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Headers([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpResponseHeaders>))] out ICoreWebView2HttpResponseHeaders headers);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StatusCode(ref int statusCode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReasonPhrase(out PWSTR reasonPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceResponseViewGetContentCompletedHandler>))] ICoreWebView2WebResourceResponseViewGetContentCompletedHandler handler);
}
