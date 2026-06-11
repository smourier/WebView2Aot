#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("06003f5e-af92-5e7e-b497-3fa167dd37c2")]
public partial interface ICoreWebView2ServiceWorkerRegistration
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ActiveServiceWorker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorker>))] out ICoreWebView2ServiceWorker value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Origin(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScopeUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TopLevelOrigin(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ServiceWorkerActivated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerActivatedEventHandler>))] ICoreWebView2ServiceWorkerActivatedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ServiceWorkerActivated(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_Unregistering([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler>))] ICoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_Unregistering(EventRegistrationToken token);
}
