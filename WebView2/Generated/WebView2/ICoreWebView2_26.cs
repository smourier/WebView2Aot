#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("806268b8-f897-5685-88e5-c45fca0b1a48")]
public partial interface ICoreWebView2_26 : ICoreWebView2_25
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_SaveFileSecurityCheckStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SaveFileSecurityCheckStartingEventHandler>))] ICoreWebView2SaveFileSecurityCheckStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_SaveFileSecurityCheckStarting(EventRegistrationToken token);
}
