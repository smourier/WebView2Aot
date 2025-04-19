#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7a6a5834-d185-4dbf-b63f-4a9bc43107d4")]
public partial interface ICoreWebView2Frame2 : ICoreWebView2Frame
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NavigationStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameNavigationStartingEventHandler>))] ICoreWebView2FrameNavigationStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NavigationStarting(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ContentLoading([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameContentLoadingEventHandler>))] ICoreWebView2FrameContentLoadingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ContentLoading(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NavigationCompleted([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameNavigationCompletedEventHandler>))] ICoreWebView2FrameNavigationCompletedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NavigationCompleted(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DOMContentLoaded([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameDOMContentLoadedEventHandler>))] ICoreWebView2FrameDOMContentLoadedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DOMContentLoaded(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteScript(PWSTR javaScript, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ExecuteScriptCompletedHandler>))] ICoreWebView2ExecuteScriptCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostWebMessageAsJson(PWSTR webMessageAsJson);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostWebMessageAsString(PWSTR webMessageAsString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_WebMessageReceived([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameWebMessageReceivedEventHandler>))] ICoreWebView2FrameWebMessageReceivedEventHandler handler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_WebMessageReceived(EventRegistrationToken token);
}
