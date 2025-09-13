#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e86cac0e-5523-465c-b536-8fb9fc8c8c60")]
public partial interface ICoreWebView2HttpRequestHeaders
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeader(PWSTR name, out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeaders(PWSTR name, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpHeadersCollectionIterator>))] out ICoreWebView2HttpHeadersCollectionIterator value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Contains(PWSTR name, ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHeader(PWSTR name, PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveHeader(PWSTR name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIterator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpHeadersCollectionIterator>))] out ICoreWebView2HttpHeadersCollectionIterator value);
}
