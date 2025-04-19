#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("fdf8b738-ee1e-4db2-a329-8d7d7b74d792")]
public partial interface ICoreWebView2NavigationCompletedEventArgs2 : ICoreWebView2NavigationCompletedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HttpStatusCode(ref int value);
}
