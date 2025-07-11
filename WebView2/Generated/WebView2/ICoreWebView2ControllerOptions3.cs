#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b32b191a-8998-57ca-b7cb-e04617e4ce4a")]
public partial interface ICoreWebView2ControllerOptions3 : ICoreWebView2ControllerOptions2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultBackgroundColor(ref COREWEBVIEW2_COLOR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultBackgroundColor(COREWEBVIEW2_COLOR value);
}
