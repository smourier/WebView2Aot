#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f1131a5e-9ba9-11eb-a8b3-0242ac130003")]
public partial interface ICoreWebView2Frame
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(ref PWSTR name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NameChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameNameChangedEventHandler>))] ICoreWebView2FrameNameChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NameChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddHostObjectToScriptWithOrigins(PWSTR name, ref VARIANT @object, uint originsCount, in PWSTR origins);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveHostObjectFromScript(PWSTR name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_Destroyed([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameDestroyedEventHandler>))] ICoreWebView2FrameDestroyedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_Destroyed(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDestroyed(ref BOOL destroyed);
}
