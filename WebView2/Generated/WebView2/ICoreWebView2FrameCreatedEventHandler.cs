#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("38059770-9baa-11eb-a8b3-0242ac130003")]
public partial interface ICoreWebView2FrameCreatedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameCreatedEventArgs>))] ICoreWebView2FrameCreatedEventArgs args);
}
