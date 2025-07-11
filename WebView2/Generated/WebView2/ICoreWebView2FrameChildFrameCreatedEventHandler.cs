#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("569e40e7-46b7-563d-83ae-1073155664d7")]
public partial interface ICoreWebView2FrameChildFrameCreatedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameCreatedEventArgs>))] ICoreWebView2FrameCreatedEventArgs args);
}
