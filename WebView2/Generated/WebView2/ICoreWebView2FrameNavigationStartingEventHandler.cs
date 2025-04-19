#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e79908bf-2d5d-4968-83db-263fea2c1da3")]
public partial interface ICoreWebView2FrameNavigationStartingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationStartingEventArgs>))] ICoreWebView2NavigationStartingEventArgs args);
}
