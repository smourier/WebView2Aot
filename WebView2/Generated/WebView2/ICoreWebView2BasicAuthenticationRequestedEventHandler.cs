#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("58b4d6c2-18d4-497e-b39b-9a96533fa278")]
public partial interface ICoreWebView2BasicAuthenticationRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BasicAuthenticationRequestedEventArgs>))] ICoreWebView2BasicAuthenticationRequestedEventArgs args);
}
