#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("517b2d1d-7dae-4a66-a4f4-10352ffb9518")]
public partial interface ICoreWebView2_15 : ICoreWebView2_14
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_FaviconChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FaviconChangedEventHandler>))] ICoreWebView2FaviconChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_FaviconChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FaviconUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFavicon(COREWEBVIEW2_FAVICON_IMAGE_FORMAT format, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2GetFaviconCompletedHandler>))] ICoreWebView2GetFaviconCompletedHandler completedHandler);
}
