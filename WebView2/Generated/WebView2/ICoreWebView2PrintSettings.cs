#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("377f3721-c74e-48ca-8db1-df68e51d60e2")]
public partial interface ICoreWebView2PrintSettings
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Orientation(ref COREWEBVIEW2_PRINT_ORIENTATION orientation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Orientation(COREWEBVIEW2_PRINT_ORIENTATION orientation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScaleFactor(ref double scaleFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ScaleFactor(double scaleFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PageWidth(ref double pageWidth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PageWidth(double pageWidth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PageHeight(ref double pageHeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PageHeight(double pageHeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MarginTop(ref double marginTop);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MarginTop(double marginTop);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MarginBottom(ref double marginBottom);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MarginBottom(double marginBottom);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MarginLeft(ref double marginLeft);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MarginLeft(double marginLeft);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MarginRight(ref double marginRight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MarginRight(double marginRight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ShouldPrintBackgrounds(ref BOOL shouldPrintBackgrounds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ShouldPrintBackgrounds(BOOL shouldPrintBackgrounds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ShouldPrintSelectionOnly(ref BOOL shouldPrintSelectionOnly);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ShouldPrintSelectionOnly(BOOL shouldPrintSelectionOnly);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ShouldPrintHeaderAndFooter(ref BOOL shouldPrintHeaderAndFooter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ShouldPrintHeaderAndFooter(BOOL shouldPrintHeaderAndFooter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HeaderTitle(ref PWSTR headerTitle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HeaderTitle(PWSTR headerTitle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FooterUri(ref PWSTR footerUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FooterUri(PWSTR footerUri);
}
