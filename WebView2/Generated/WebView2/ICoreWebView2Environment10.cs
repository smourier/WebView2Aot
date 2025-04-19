#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ee0eb9df-6f12-46ce-b53f-3f47b9c928e0")]
public partial interface ICoreWebView2Environment10 : ICoreWebView2Environment9
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreWebView2ControllerOptions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ControllerOptions>))] out ICoreWebView2ControllerOptions value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreWebView2ControllerWithOptions(HWND ParentWindow, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ControllerOptions>))] ICoreWebView2ControllerOptions options, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CreateCoreWebView2ControllerCompletedHandler>))] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreWebView2CompositionControllerWithOptions(HWND ParentWindow, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ControllerOptions>))] ICoreWebView2ControllerOptions options, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler>))] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);
}
