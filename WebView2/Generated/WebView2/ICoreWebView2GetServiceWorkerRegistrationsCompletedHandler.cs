#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ea83432f-6528-592f-903b-0917eb0fd9c7")]
public partial interface ICoreWebView2GetServiceWorkerRegistrationsCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegistrationCollectionView>))] ICoreWebView2ServiceWorkerRegistrationCollectionView result);
}
