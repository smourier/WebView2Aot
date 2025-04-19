#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9da43ccc-26e1-4dad-b56c-d8961c94c571")]
public partial interface ICoreWebView2CursorChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CompositionController>))] ICoreWebView2CompositionController sender, IUnknown args);
}
