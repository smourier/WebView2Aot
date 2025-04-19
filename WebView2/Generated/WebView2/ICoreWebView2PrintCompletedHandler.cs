#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8fd80075-ed08-42db-8570-f5d14977461e")]
public partial interface ICoreWebView2PrintCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, COREWEBVIEW2_PRINT_STATUS result);
}
