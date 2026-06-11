#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("65f0a1a6-a295-5a9f-8041-70db71566f98")]
public partial interface ICoreWebView2ServiceWorkerWebMessageReceivedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorker>))] ICoreWebView2ServiceWorker sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebMessageReceivedEventArgs>))] ICoreWebView2WebMessageReceivedEventArgs args);
}
