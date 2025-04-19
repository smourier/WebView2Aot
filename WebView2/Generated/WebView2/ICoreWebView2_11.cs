#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0be78e56-c193-4051-b943-23b460c08bdb")]
public partial interface ICoreWebView2_11 : ICoreWebView2_10
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallDevToolsProtocolMethodForSession(PWSTR sessionId, PWSTR methodName, PWSTR parametersAsJson, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CallDevToolsProtocolMethodCompletedHandler>))] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ContextMenuRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuRequestedEventHandler>))] ICoreWebView2ContextMenuRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ContextMenuRequested(EventRegistrationToken token);
}
