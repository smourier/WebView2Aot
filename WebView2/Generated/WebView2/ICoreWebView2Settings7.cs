#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("488dc902-35ef-42d2-bc7d-94b65c4bc49c")]
public partial interface ICoreWebView2Settings7 : ICoreWebView2Settings6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HiddenPdfToolbarItems(ref COREWEBVIEW2_PDF_TOOLBAR_ITEMS value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HiddenPdfToolbarItems(COREWEBVIEW2_PDF_TOOLBAR_ITEMS value);
}
