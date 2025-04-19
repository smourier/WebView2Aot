#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("03c5ff5a-9b45-4a88-881c-89a9f328619c")]
public partial interface ICoreWebView2HttpResponseHeaders
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendHeader(PWSTR name, PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Contains(PWSTR name, ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeader(PWSTR name, ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeaders(PWSTR name, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpHeadersCollectionIterator>))] out ICoreWebView2HttpHeadersCollectionIterator value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIterator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpHeadersCollectionIterator>))] out ICoreWebView2HttpHeadersCollectionIterator value);
}
