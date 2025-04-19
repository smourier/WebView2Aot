#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ab71d500-0820-4a52-809c-48db04ff93bf")]
public partial interface ICoreWebView2NonClientRegionChangedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RegionKind(ref COREWEBVIEW2_NON_CLIENT_REGION_KIND value);
}
