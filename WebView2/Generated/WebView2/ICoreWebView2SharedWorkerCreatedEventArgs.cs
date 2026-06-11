#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9f6615b0-08f1-5baa-9c95-a02a1dc56d3f")]
public partial interface ICoreWebView2SharedWorkerCreatedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Worker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorker>))] out ICoreWebView2SharedWorker value);
}
