#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3e28d307-9d58-5306-8097-a79301de4f05")]
public partial interface ICoreWebView2FrameDedicatedWorkerCreatedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorkerCreatedEventArgs>))] ICoreWebView2DedicatedWorkerCreatedEventArgs args);
}
