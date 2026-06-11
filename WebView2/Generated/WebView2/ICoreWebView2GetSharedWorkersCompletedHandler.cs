#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("1f3179ae-15e5-51e4-8583-be0caf85adc7")]
public partial interface ICoreWebView2GetSharedWorkersCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorkerCollectionView>))] ICoreWebView2SharedWorkerCollectionView result);
}
