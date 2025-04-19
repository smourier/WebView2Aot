#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9e8f0cf8-e670-4b5e-b2bc-73e061e3184c")]
public partial interface ICoreWebView2_2 : ICoreWebView2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_WebResourceResponseReceived([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceResponseReceivedEventHandler>))] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_WebResourceResponseReceived(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NavigateWithWebResourceRequest([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceRequest>))] ICoreWebView2WebResourceRequest request);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DOMContentLoaded([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DOMContentLoadedEventHandler>))] ICoreWebView2DOMContentLoadedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DOMContentLoaded(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CookieManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CookieManager>))] out ICoreWebView2CookieManager cookieManager);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Environment([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Environment>))] out ICoreWebView2Environment environment);
}
