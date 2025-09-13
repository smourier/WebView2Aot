#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("653c2959-bb3a-4377-8632-b58ada4e66c4")]
public partial interface ICoreWebView2DevToolsProtocolEventReceivedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ParameterObjectAsJson(out PWSTR value);
}
