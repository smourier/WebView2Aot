#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("2d6aa13b-3839-4a15-92fc-d88b3c0d9c9d")]
public partial interface ICoreWebView2MoveFocusRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Reason(ref COREWEBVIEW2_MOVE_FOCUS_REASON reason);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL value);
}
