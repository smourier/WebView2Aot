#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0528a73b-e92d-49f4-927a-e547dddaa37d")]
public partial interface ICoreWebView2Settings9 : ICoreWebView2Settings8
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsNonClientRegionSupportEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsNonClientRegionSupportEnabled(BOOL value);
}
