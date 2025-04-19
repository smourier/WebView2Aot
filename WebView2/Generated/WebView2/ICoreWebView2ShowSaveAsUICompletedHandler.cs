#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e24b07e3-8169-5c34-994a-7f6478946a3c")]
public partial interface ICoreWebView2ShowSaveAsUICompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, COREWEBVIEW2_SAVE_AS_UI_RESULT result);
}
