#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("910c52af-8129-516d-ab9a-b524e377d8ac")]
public partial interface ICoreWebView2DedicatedWorkerCreatedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OriginalSourceFrameInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfo>))] out ICoreWebView2FrameInfo value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Worker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorker>))] out ICoreWebView2DedicatedWorker value);
}
