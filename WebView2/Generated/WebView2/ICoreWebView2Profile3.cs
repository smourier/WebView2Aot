#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b188e659-5685-4e05-bdba-fc640e0f1992")]
public partial interface ICoreWebView2Profile3 : ICoreWebView2Profile2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PreferredTrackingPreventionLevel(ref COREWEBVIEW2_TRACKING_PREVENTION_LEVEL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PreferredTrackingPreventionLevel(COREWEBVIEW2_TRACKING_PREVENTION_LEVEL value);
}
