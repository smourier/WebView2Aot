#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e2fda4be-5456-406c-a261-3d452138362c")]
public partial interface ICoreWebView2DevToolsProtocolEventReceivedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DevToolsProtocolEventReceivedEventArgs>))] ICoreWebView2DevToolsProtocolEventReceivedEventArgs args);
}
