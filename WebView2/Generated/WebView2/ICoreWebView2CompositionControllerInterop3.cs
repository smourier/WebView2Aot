#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b211edcf-7ef3-44ad-8aed-4d3ef0af1813")]
public partial interface ICoreWebView2CompositionControllerInterop3 : ICoreWebView2CompositionControllerInterop2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DragStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DragStartingEventHandler>))] ICoreWebView2DragStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DragStarting(EventRegistrationToken token);
}
