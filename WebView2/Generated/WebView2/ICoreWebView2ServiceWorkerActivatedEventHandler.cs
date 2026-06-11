#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ecaa9897-769d-5ece-a1e5-8859818caf86")]
public partial interface ICoreWebView2ServiceWorkerActivatedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegistration>))] ICoreWebView2ServiceWorkerRegistration sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerActivatedEventArgs>))] ICoreWebView2ServiceWorkerActivatedEventArgs args);
}
