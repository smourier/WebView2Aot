#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b7434d98-6bc8-419d-9da5-fb5a96d4dacd")]
public partial interface ICoreWebView2Notification
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_CloseRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NotificationCloseRequestedEventHandler>))] ICoreWebView2NotificationCloseRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_CloseRequested(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportShown();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportClicked();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportClosed();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Body(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Direction(ref COREWEBVIEW2_TEXT_DIRECTION_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Language(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Tag(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IconUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Title(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BadgeUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BodyImageUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ShouldRenotify(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequiresInteraction(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsSilent(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Timestamp(ref double value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVibrationPattern(ref uint count, ref ulong vibrationPattern);
}
