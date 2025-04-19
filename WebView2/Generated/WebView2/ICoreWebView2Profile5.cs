#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("2ee5b76e-6e80-4df2-bcd3-d4ec3340a01b")]
public partial interface ICoreWebView2Profile5 : ICoreWebView2Profile4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CookieManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CookieManager>))] out ICoreWebView2CookieManager value);
}
