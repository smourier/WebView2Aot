#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("83d8cfa9-ef83-5447-9431-91c203c4c9d8")]
public partial interface ICoreWebView2ServiceWorkerRegistrationCollectionView
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegistration>))] out ICoreWebView2ServiceWorkerRegistration value);
}
