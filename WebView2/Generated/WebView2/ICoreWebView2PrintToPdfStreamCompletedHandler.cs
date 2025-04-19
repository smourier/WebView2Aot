#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4c9f8229-8f93-444f-a711-2c0dfd6359d5")]
public partial interface ICoreWebView2PrintToPdfStreamCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, IStream result);
}
