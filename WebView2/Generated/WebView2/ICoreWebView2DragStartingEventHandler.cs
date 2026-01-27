#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3b149321-83c3-5d1f-b03f-a42899bc1c15")]
public partial interface ICoreWebView2DragStartingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CompositionController>))] ICoreWebView2CompositionController sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DragStartingEventArgs>))] ICoreWebView2DragStartingEventArgs args);
}
