#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7c367b9b-3d2b-450f-9e58-d61a20f486aa")]
public partial interface ICoreWebView2CompositionController4 : ICoreWebView2CompositionController3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNonClientRegionAtPoint(POINT point, ref COREWEBVIEW2_NON_CLIENT_REGION_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryNonClientRegion(COREWEBVIEW2_NON_CLIENT_REGION_KIND kind, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2RegionRectCollectionView>))] out ICoreWebView2RegionRectCollectionView rects);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NonClientRegionChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NonClientRegionChangedEventHandler>))] ICoreWebView2NonClientRegionChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NonClientRegionChanged(EventRegistrationToken token);
}
