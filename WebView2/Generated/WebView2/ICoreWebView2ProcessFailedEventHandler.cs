#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("79e0aea4-990b-42d9-aa1d-0fcc2e5bc7f1")]
public partial interface ICoreWebView2ProcessFailedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessFailedEventArgs>))] ICoreWebView2ProcessFailedEventArgs args);
}
