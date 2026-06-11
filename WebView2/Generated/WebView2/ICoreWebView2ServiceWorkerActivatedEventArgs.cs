#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5685c4b6-a514-58b2-9721-b61ef4ccd9d8")]
public partial interface ICoreWebView2ServiceWorkerActivatedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ActiveServiceWorker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorker>))] out ICoreWebView2ServiceWorker value);
}
