#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0d6156f2-d332-49a7-9e03-7d8f2feeee54")]
public partial interface ICoreWebView2FrameContentLoadingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContentLoadingEventArgs>))] ICoreWebView2ContentLoadingEventArgs args);
}
