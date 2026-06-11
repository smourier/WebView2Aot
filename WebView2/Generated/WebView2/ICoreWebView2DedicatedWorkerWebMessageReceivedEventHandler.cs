#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b366218b-0bb8-58a3-ac33-f40a2235366e")]
public partial interface ICoreWebView2DedicatedWorkerWebMessageReceivedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorker>))] ICoreWebView2DedicatedWorker sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebMessageReceivedEventArgs>))] ICoreWebView2WebMessageReceivedEventArgs args);
}
