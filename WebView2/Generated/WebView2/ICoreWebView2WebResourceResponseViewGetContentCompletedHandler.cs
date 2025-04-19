#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("875738e1-9fa2-40e3-8b74-2e8972dd6fe7")]
public partial interface ICoreWebView2WebResourceResponseViewGetContentCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, IStream result);
}
