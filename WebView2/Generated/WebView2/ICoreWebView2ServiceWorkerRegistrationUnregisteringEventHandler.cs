#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("bec01d14-6ad9-5257-9ff6-84f01baa0cca")]
public partial interface ICoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegistration>))] ICoreWebView2ServiceWorkerRegistration sender, IUnknown args);
}
