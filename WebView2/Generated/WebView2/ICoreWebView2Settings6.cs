#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("11cb3acd-9bc8-43b8-83bf-f40753714f87")]
public partial interface ICoreWebView2Settings6 : ICoreWebView2Settings5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsSwipeNavigationEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsSwipeNavigationEnabled(BOOL value);
}
