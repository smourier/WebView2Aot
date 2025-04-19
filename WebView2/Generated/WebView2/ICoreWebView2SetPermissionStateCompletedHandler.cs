#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("fc77fb30-9c9e-4076-b8c7-7644a703ca1b")]
public partial interface ICoreWebView2SetPermissionStateCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode);
}
