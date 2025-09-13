#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f2c19559-6bc1-4583-a757-90021be9afec")]
public partial interface ICoreWebView2File
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out PWSTR value);
}
