#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("28f0d425-93fe-4e63-9f8d-2aeec6d3ba1e")]
public partial interface ICoreWebView2EstimatedEndTimeChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DownloadOperation>))] ICoreWebView2DownloadOperation sender, IUnknown args);
}
