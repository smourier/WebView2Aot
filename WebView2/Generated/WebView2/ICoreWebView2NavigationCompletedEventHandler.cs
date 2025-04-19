#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("d33a35bf-1c49-4f98-93ab-006e0533fe1c")]
public partial interface ICoreWebView2NavigationCompletedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationCompletedEventArgs>))] ICoreWebView2NavigationCompletedEventArgs args);
}
