#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c7528449-5674-5e34-b990-ff4cef046214")]
public partial interface ICoreWebView2ServiceWorkerDestroyingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorker>))] ICoreWebView2ServiceWorker sender, IUnknown args);
}
