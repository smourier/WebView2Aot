#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("177cd9e7-b6f5-451a-94a0-5d7a3a4c4141")]
public partial interface ICoreWebView2CookieManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCookie(PWSTR name, PWSTR value, PWSTR domain, PWSTR path, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Cookie>))] out ICoreWebView2Cookie cookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyCookie([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Cookie>))] ICoreWebView2Cookie cookieParam, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Cookie>))] out ICoreWebView2Cookie cookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCookies(PWSTR uri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2GetCookiesCompletedHandler>))] ICoreWebView2GetCookiesCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddOrUpdateCookie([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Cookie>))] ICoreWebView2Cookie cookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteCookie([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Cookie>))] ICoreWebView2Cookie cookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteCookies(PWSTR name, PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteCookiesWithDomainAndPath(PWSTR name, PWSTR domain, PWSTR path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteAllCookies();
}
