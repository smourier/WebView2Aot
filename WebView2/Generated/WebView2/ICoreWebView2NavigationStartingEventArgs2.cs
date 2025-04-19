#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9086be93-91aa-472d-a7e0-579f2ba006ad")]
public partial interface ICoreWebView2NavigationStartingEventArgs2 : ICoreWebView2NavigationStartingEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AdditionalAllowedFrameAncestors(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AdditionalAllowedFrameAncestors(PWSTR value);
}
