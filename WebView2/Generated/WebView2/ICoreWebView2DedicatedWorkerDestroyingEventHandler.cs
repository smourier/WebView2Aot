#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("72473d5f-cba2-57ca-a42e-03610a349fef")]
public partial interface ICoreWebView2DedicatedWorkerDestroyingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorker>))] ICoreWebView2DedicatedWorker sender, IUnknown args);
}
