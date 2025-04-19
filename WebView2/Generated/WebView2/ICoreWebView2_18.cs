#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7a626017-28be-49b2-b865-3ba2b3522d90")]
public partial interface ICoreWebView2_18 : ICoreWebView2_17
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_LaunchingExternalUriScheme([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2LaunchingExternalUriSchemeEventHandler>))] ICoreWebView2LaunchingExternalUriSchemeEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_LaunchingExternalUriScheme(EventRegistrationToken token);
}
