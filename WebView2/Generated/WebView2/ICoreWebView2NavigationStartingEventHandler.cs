#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9adbe429-f36d-432b-9ddc-f8881fbd76e3")]
public partial interface ICoreWebView2NavigationStartingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationStartingEventArgs>))] ICoreWebView2NavigationStartingEventArgs args);
}
