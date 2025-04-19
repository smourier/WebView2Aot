#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e371e005-6d1d-4517-934b-a8f1629c62a5")]
public partial interface ICoreWebView2FrameWebMessageReceivedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebMessageReceivedEventArgs>))] ICoreWebView2WebMessageReceivedEventArgs args);
}
