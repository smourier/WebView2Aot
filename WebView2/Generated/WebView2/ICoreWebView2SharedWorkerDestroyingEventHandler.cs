#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5a459f84-fd04-5cce-a998-6fab56f09eeb")]
public partial interface ICoreWebView2SharedWorkerDestroyingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorker>))] ICoreWebView2SharedWorker sender, IUnknown args);
}
