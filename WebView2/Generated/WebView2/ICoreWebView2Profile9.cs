#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("40c764d0-12fc-5d23-816d-971b353174c1")]
public partial interface ICoreWebView2Profile9 : ICoreWebView2Profile8
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AreWebViewScriptApisEnabledForServiceWorkers(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AreWebViewScriptApisEnabledForServiceWorkers(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ServiceWorkerManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerManager>))] out ICoreWebView2ServiceWorkerManager value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SharedWorkerManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorkerManager>))] out ICoreWebView2SharedWorkerManager value);
}
