#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5a4f5069-5c15-47c3-8646-f4de1c116670")]
public partial interface ICoreWebView2GetCookiesCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CookieList>))] ICoreWebView2CookieList result);
}
