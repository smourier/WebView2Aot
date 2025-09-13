#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3d6b6cf2-afe1-44c7-a995-c65117714336")]
public partial interface ICoreWebView2DownloadOperation
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_BytesReceivedChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BytesReceivedChangedEventHandler>))] ICoreWebView2BytesReceivedChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_BytesReceivedChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_EstimatedEndTimeChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2EstimatedEndTimeChangedEventHandler>))] ICoreWebView2EstimatedEndTimeChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_EstimatedEndTimeChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_StateChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2StateChangedEventHandler>))] ICoreWebView2StateChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_StateChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Uri(out PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ContentDisposition(out PWSTR contentDisposition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MimeType(out PWSTR mimeType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TotalBytesToReceive(ref long totalBytesToReceive);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BytesReceived(ref long bytesReceived);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EstimatedEndTime(out PWSTR estimatedEndTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ResultFilePath(out PWSTR resultFilePath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(ref COREWEBVIEW2_DOWNLOAD_STATE downloadState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InterruptReason(ref COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON interruptReason);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CanResume(ref BOOL canResume);
}
