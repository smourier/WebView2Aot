#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b99369f3-9b11-47b5-bc6f-8e7895fcea17")]
public partial interface ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, PWSTR result);
}
