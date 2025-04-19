#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3117da26-ae13-438d-bd46-edbeb2c4ce81")]
public partial interface ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
