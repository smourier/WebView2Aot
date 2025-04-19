#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9f760f8a-fb79-42be-9990-7b56900fa9c7")]
public partial interface ICoreWebView2AcceleratorKeyPressedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeyEventKind(ref COREWEBVIEW2_KEY_EVENT_KIND keyEventKind);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VirtualKey(ref uint virtualKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeyEventLParam(ref int lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhysicalKeyStatus(ref COREWEBVIEW2_PHYSICAL_KEY_STATUS physicalKeyStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL handled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL handled);
}
