#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("845d0edd-8bd8-429b-9915-4821789f23e9")]
public partial interface ICoreWebView2FramePermissionRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PermissionRequestedEventArgs2>))] ICoreWebView2PermissionRequestedEventArgs2 args);
}
