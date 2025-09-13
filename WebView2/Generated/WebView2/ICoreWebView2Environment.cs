#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b96d755e-0319-4e92-a296-23436f46a1fc")]
public partial interface ICoreWebView2Environment
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreWebView2Controller(HWND parentWindow, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CreateCoreWebView2ControllerCompletedHandler>))] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateWebResourceResponse(IStream content, int statusCode, PWSTR reasonPhrase, PWSTR headers, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceResponse>))] out ICoreWebView2WebResourceResponse response);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BrowserVersionString(out PWSTR versionInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NewBrowserVersionAvailable([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NewBrowserVersionAvailableEventHandler>))] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NewBrowserVersionAvailable(EventRegistrationToken token);
}
