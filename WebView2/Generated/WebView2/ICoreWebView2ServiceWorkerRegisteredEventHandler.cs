#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c024c910-4df2-54a3-b5c1-6152ca0e4577")]
public partial interface ICoreWebView2ServiceWorkerRegisteredEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerManager>))] ICoreWebView2ServiceWorkerManager sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegisteredEventArgs>))] ICoreWebView2ServiceWorkerRegisteredEventArgs args);
}
