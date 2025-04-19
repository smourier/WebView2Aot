#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f7f6f714-5d2a-43c6-9503-346ece02d186")]
public partial interface ICoreWebView2CookieList
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Cookie>))] out ICoreWebView2Cookie value);
}
