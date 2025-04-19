#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("04d3fe1d-ab87-42fb-a898-da241d35b63c")]
public partial interface ICoreWebView2ContextMenuRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuRequestedEventArgs>))] ICoreWebView2ContextMenuRequestedEventArgs args);
}
