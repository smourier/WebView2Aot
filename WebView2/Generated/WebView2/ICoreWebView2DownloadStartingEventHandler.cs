#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("efedc989-c396-41ca-83f7-07f845a55724")]
public partial interface ICoreWebView2DownloadStartingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DownloadStartingEventArgs>))] ICoreWebView2DownloadStartingEventArgs args);
}
