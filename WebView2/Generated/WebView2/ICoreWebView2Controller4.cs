#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("97d418d5-a426-4e49-a151-e1a10f327d9e")]
public partial interface ICoreWebView2Controller4 : ICoreWebView2Controller3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowExternalDrop(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowExternalDrop(BOOL value);
}
