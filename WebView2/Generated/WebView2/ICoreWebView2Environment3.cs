#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("80a22ae3-be7c-4ce2-afe1-5a50056cdeeb")]
public partial interface ICoreWebView2Environment3 : ICoreWebView2Environment2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreWebView2CompositionController(HWND ParentWindow, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler>))] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreWebView2PointerInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PointerInfo>))] out ICoreWebView2PointerInfo value);
}
