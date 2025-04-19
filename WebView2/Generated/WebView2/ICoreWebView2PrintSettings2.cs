#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ca7f0e1f-3484-41d1-8c1a-65cd44a63f8d")]
public partial interface ICoreWebView2PrintSettings2 : ICoreWebView2PrintSettings
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PageRanges(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PageRanges(PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PagesPerSide(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PagesPerSide(int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Copies(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Copies(int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Collation(ref COREWEBVIEW2_PRINT_COLLATION value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Collation(COREWEBVIEW2_PRINT_COLLATION value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ColorMode(ref COREWEBVIEW2_PRINT_COLOR_MODE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ColorMode(COREWEBVIEW2_PRINT_COLOR_MODE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Duplex(ref COREWEBVIEW2_PRINT_DUPLEX value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Duplex(COREWEBVIEW2_PRINT_DUPLEX value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaSize(ref COREWEBVIEW2_PRINT_MEDIA_SIZE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MediaSize(COREWEBVIEW2_PRINT_MEDIA_SIZE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PrinterName(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PrinterName(PWSTR value);
}
