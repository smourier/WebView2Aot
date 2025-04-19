#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("81336594-7ede-4ba9-bf71-acf0a95b58dd")]
public partial interface ICoreWebView2StateChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DownloadOperation>))] ICoreWebView2DownloadOperation sender, IUnknown args);
}
