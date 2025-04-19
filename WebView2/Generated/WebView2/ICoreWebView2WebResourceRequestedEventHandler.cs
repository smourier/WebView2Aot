#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ab00b74c-15f1-4646-80e8-e76341d25d71")]
public partial interface ICoreWebView2WebResourceRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceRequestedEventArgs>))] ICoreWebView2WebResourceRequestedEventArgs args);
}
