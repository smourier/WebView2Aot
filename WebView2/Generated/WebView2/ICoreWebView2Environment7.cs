#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("43c22296-3bbd-43a4-9c00-5c0df6dd29a2")]
public partial interface ICoreWebView2Environment7 : ICoreWebView2Environment6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserDataFolder(out PWSTR value);
}
