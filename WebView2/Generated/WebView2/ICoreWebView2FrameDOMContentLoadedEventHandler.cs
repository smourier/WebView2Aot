#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("38d9520d-340f-4d1e-a775-43fce9753683")]
public partial interface ICoreWebView2FrameDOMContentLoadedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DOMContentLoadedEventArgs>))] ICoreWebView2DOMContentLoadedEventArgs args);
}
