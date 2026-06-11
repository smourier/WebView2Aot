#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9deff655-e3d5-5b8f-9107-52e66b3ec3fc")]
public partial interface ICoreWebView2Frame8 : ICoreWebView2Frame7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DedicatedWorkerCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameDedicatedWorkerCreatedEventHandler>))] ICoreWebView2FrameDedicatedWorkerCreatedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DedicatedWorkerCreated(EventRegistrationToken token);
}
