#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8d0f82eb-7c33-5a4c-9108-84ca28ccc3b4")]
public partial interface ICoreWebView2CompositionController5 : ICoreWebView2CompositionController4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DragStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DragStartingEventHandler>))] ICoreWebView2DragStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DragStarting(EventRegistrationToken token);
}
