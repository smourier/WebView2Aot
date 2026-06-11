#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("cba7462c-52c1-5706-8bbc-e9fc36476de4")]
public partial interface ICoreWebView2DedicatedWorkerCreatedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorkerCreatedEventArgs>))] ICoreWebView2DedicatedWorkerCreatedEventArgs args);
}
