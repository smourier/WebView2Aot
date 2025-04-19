#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("89c5d598-8788-423b-be97-e6e01c0f9ee3")]
public partial interface ICoreWebView2NotificationReceivedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NotificationReceivedEventArgs>))] ICoreWebView2NotificationReceivedEventArgs args);
}
