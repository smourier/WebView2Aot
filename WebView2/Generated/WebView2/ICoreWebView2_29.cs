#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("650f917e-cc16-5c8c-9287-b0bbc8a4ab2c")]
public partial interface ICoreWebView2_29 : ICoreWebView2_28
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DedicatedWorkerCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorkerCreatedEventHandler>))] ICoreWebView2DedicatedWorkerCreatedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DedicatedWorkerCreated(EventRegistrationToken token);
}
