#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5c4889f0-5ef6-4c5a-952c-d8f1b92d0574")]
public partial interface ICoreWebView2CallDevToolsProtocolMethodCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, PWSTR result);
}
