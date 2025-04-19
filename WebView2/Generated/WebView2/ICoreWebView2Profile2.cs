#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("fa740d4b-5eae-4344-a8ad-74be31925397")]
public partial interface ICoreWebView2Profile2 : ICoreWebView2Profile
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearBrowsingData(COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClearBrowsingDataCompletedHandler>))] ICoreWebView2ClearBrowsingDataCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearBrowsingDataInTimeRange(COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, double startTime, double endTime, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClearBrowsingDataCompletedHandler>))] ICoreWebView2ClearBrowsingDataCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearBrowsingDataAll([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ClearBrowsingDataCompletedHandler>))] ICoreWebView2ClearBrowsingDataCompletedHandler handler);
}
