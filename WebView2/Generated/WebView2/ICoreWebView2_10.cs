#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b1690564-6f5a-4983-8e48-31d1143fecdb")]
public partial interface ICoreWebView2_10 : ICoreWebView2_9
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_BasicAuthenticationRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BasicAuthenticationRequestedEventHandler>))] ICoreWebView2BasicAuthenticationRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_BasicAuthenticationRequested(EventRegistrationToken token);
}
