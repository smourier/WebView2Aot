#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b32ca51a-8371-45e9-9317-af021d080367")]
public partial interface ICoreWebView2DevToolsProtocolEventReceiver
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DevToolsProtocolEventReceived([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DevToolsProtocolEventReceivedEventHandler>))] ICoreWebView2DevToolsProtocolEventReceivedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DevToolsProtocolEventReceived(EventRegistrationToken token);
}
