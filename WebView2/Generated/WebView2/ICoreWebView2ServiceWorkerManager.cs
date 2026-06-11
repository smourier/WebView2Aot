#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a2d52fd4-9b10-5971-8499-c67d1560f47a")]
public partial interface ICoreWebView2ServiceWorkerManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ServiceWorkerRegistered([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegisteredEventHandler>))] ICoreWebView2ServiceWorkerRegisteredEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ServiceWorkerRegistered(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceWorkerRegistrations([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2GetServiceWorkerRegistrationsCompletedHandler>))] ICoreWebView2GetServiceWorkerRegistrationsCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceWorkerRegistrationsForScope(PWSTR scopeUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2GetServiceWorkerRegistrationsCompletedHandler>))] ICoreWebView2GetServiceWorkerRegistrationsCompletedHandler handler);
}
