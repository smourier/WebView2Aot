#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("609302ad-0e36-4f9a-a210-6a45272842a9")]
public partial interface ICoreWebView2FrameNavigationCompletedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationCompletedEventArgs>))] ICoreWebView2NavigationCompletedEventArgs args);
}
