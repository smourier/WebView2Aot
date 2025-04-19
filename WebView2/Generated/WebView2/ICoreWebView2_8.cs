#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e9632730-6e1e-43ab-b7b8-7b2c9e62e094")]
public partial interface ICoreWebView2_8 : ICoreWebView2_7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_IsMutedChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2IsMutedChangedEventHandler>))] ICoreWebView2IsMutedChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_IsMutedChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsMuted(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsMuted(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_IsDocumentPlayingAudioChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2IsDocumentPlayingAudioChangedEventHandler>))] ICoreWebView2IsDocumentPlayingAudioChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_IsDocumentPlayingAudioChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsDocumentPlayingAudio(ref BOOL value);
}
