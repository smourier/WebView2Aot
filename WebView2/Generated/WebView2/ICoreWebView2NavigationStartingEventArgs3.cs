#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ddffe494-4942-4bd2-ab73-35b8ff40e19f")]
public partial interface ICoreWebView2NavigationStartingEventArgs3 : ICoreWebView2NavigationStartingEventArgs2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NavigationKind(ref COREWEBVIEW2_NAVIGATION_KIND value);
}
