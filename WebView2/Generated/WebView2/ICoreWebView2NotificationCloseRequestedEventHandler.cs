#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("47c32d23-1e94-4733-85f1-d9bf4acd0974")]
public partial interface ICoreWebView2NotificationCloseRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Notification>))] ICoreWebView2Notification sender, IUnknown args);
}
