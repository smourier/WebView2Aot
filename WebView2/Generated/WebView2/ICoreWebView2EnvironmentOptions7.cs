#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c48d539f-e39f-441c-ae68-1f66e570bdc5")]
public partial interface ICoreWebView2EnvironmentOptions7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ChannelSearchKind(ref COREWEBVIEW2_CHANNEL_SEARCH_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ChannelSearchKind(COREWEBVIEW2_CHANNEL_SEARCH_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReleaseChannels(ref COREWEBVIEW2_RELEASE_CHANNELS value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ReleaseChannels(COREWEBVIEW2_RELEASE_CHANNELS value);
}
