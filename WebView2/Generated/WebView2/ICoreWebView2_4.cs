#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("20d02d59-6df2-42dc-bd06-f98a694b1302")]
public partial interface ICoreWebView2_4 : ICoreWebView2_3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_FrameCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameCreatedEventHandler>))] ICoreWebView2FrameCreatedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_FrameCreated(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DownloadStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DownloadStartingEventHandler>))] ICoreWebView2DownloadStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DownloadStarting(EventRegistrationToken token);
}
