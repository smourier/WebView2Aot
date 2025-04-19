#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4a794e66-aa6c-46bd-93a3-382196837680")]
public partial interface ICoreWebView2NonClientRegionChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CompositionController>))] ICoreWebView2CompositionController sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NonClientRegionChangedEventArgs>))] ICoreWebView2NonClientRegionChangedEventArgs args);
}
