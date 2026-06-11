#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c6172932-407a-553b-b4d1-cdd12605eb6a")]
public partial interface ICoreWebView2ServiceWorkerRegisteredEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ServiceWorkerRegistration([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerRegistration>))] out ICoreWebView2ServiceWorkerRegistration value);
}
