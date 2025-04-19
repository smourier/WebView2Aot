#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4d7b2eab-9fdc-468d-b998-a9260b5ed651")]
public partial interface ICoreWebView2_9 : ICoreWebView2_8
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_IsDefaultDownloadDialogOpenChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler>))] ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler handler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_IsDefaultDownloadDialogOpenChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsDefaultDownloadDialogOpen(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenDefaultDownloadDialog();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloseDefaultDownloadDialog();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultDownloadDialogCornerAlignment(ref COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultDownloadDialogCornerAlignment(COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultDownloadDialogMargin(ref POINT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultDownloadDialogMargin(POINT value);
}
