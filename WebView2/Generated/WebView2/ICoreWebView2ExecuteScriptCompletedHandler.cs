#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("49511172-cc67-4bca-9923-137112f4c4cc")]
public partial interface ICoreWebView2ExecuteScriptCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, PWSTR result);
}
