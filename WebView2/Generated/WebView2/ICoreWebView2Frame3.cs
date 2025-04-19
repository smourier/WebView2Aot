#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b50d82cc-cc28-481d-9614-cb048895e6a0")]
public partial interface ICoreWebView2Frame3 : ICoreWebView2Frame2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_PermissionRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FramePermissionRequestedEventHandler>))] ICoreWebView2FramePermissionRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_PermissionRequested(EventRegistrationToken token);
}
