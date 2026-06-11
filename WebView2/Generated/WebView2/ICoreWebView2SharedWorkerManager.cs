#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9b897103-d035-551f-892e-3e8f2916d03e")]
public partial interface ICoreWebView2SharedWorkerManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_SharedWorkerCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorkerCreatedEventHandler>))] ICoreWebView2SharedWorkerCreatedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_SharedWorkerCreated(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharedWorkers([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2GetSharedWorkersCompletedHandler>))] ICoreWebView2GetSharedWorkersCompletedHandler handler);
}
