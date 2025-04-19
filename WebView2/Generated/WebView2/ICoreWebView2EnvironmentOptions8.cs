#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7c7ecf51-e918-5caf-853c-e9a2bcc27775")]
public partial interface ICoreWebView2EnvironmentOptions8
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScrollBarStyle(ref COREWEBVIEW2_SCROLLBAR_STYLE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ScrollBarStyle(COREWEBVIEW2_SCROLLBAR_STYLE value);
}
