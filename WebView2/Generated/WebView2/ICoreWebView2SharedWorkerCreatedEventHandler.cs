#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("79cb8524-b842-551a-8d31-5f824b6955ed")]
public partial interface ICoreWebView2SharedWorkerCreatedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorkerManager>))] ICoreWebView2SharedWorkerManager sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorkerCreatedEventArgs>))] ICoreWebView2SharedWorkerCreatedEventArgs args);
}
