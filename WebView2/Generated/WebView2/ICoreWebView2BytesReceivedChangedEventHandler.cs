#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("828e8ab6-d94c-4264-9cef-5217170d6251")]
public partial interface ICoreWebView2BytesReceivedChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DownloadOperation>))] ICoreWebView2DownloadOperation sender, IUnknown args);
}
