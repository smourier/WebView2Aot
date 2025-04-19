#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("69035451-6dc7-4cb8-9bce-b2bd70ad289f")]
public partial interface ICoreWebView2MoveFocusRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Controller>))] ICoreWebView2Controller sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2MoveFocusRequestedEventArgs>))] ICoreWebView2MoveFocusRequestedEventArgs args);
}
