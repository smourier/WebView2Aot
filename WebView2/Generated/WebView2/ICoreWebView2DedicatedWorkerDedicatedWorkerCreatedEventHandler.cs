#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a85b1b35-f6d7-5ae6-9fd7-57905deff79f")]
public partial interface ICoreWebView2DedicatedWorkerDedicatedWorkerCreatedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorker>))] ICoreWebView2DedicatedWorker sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorkerCreatedEventArgs>))] ICoreWebView2DedicatedWorkerCreatedEventArgs args);
}
