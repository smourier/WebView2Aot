#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0c8a1275-9b6b-4901-87ad-70df25bafa6e")]
public partial interface ICoreWebView2ContentLoadingEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsErrorPage(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NavigationId(ref ulong value);
}
