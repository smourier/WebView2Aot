#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("2dc4959d-1494-4393-95ba-bea4cb9ebd1b")]
public partial interface ICoreWebView2DevToolsProtocolEventReceivedEventArgs2 : ICoreWebView2DevToolsProtocolEventReceivedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SessionId(out PWSTR value);
}
