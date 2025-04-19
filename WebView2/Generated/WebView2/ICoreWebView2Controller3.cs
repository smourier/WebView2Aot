#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f9614724-5d2b-41dc-aef7-73d62b51543b")]
public partial interface ICoreWebView2Controller3 : ICoreWebView2Controller2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RasterizationScale(ref double scale);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RasterizationScale(double scale);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ShouldDetectMonitorScaleChanges(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ShouldDetectMonitorScaleChanges(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_RasterizationScaleChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2RasterizationScaleChangedEventHandler>))] ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_RasterizationScaleChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BoundsMode(ref COREWEBVIEW2_BOUNDS_MODE boundsMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BoundsMode(COREWEBVIEW2_BOUNDS_MODE boundsMode);
}
