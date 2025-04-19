#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4bac7e9c-199e-49ed-87ed-249303acf019")]
public partial interface ICoreWebView2DOMContentLoadedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DOMContentLoadedEventArgs>))] ICoreWebView2DOMContentLoadedEventArgs args);
}
