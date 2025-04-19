#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7de9898a-24f5-40c3-a2de-d4f458e69828")]
public partial interface ICoreWebView2WebResourceResponseReceivedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceResponseReceivedEventArgs>))] ICoreWebView2WebResourceResponseReceivedEventArgs args);
}
