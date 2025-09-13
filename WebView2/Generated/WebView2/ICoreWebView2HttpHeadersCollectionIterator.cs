#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0702fc30-f43b-47bb-ab52-a42cb552ad9f")]
public partial interface ICoreWebView2HttpHeadersCollectionIterator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentHeader(out PWSTR name, out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HasCurrentHeader(ref BOOL hasCurrent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveNext(ref BOOL hasNext);
}
