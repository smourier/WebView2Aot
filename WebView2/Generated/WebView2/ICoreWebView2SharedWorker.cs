#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("bcd39c8d-48bb-5f1b-be22-89f9c0c4484a")]
public partial interface ICoreWebView2SharedWorker
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Origin(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScriptUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TopLevelOrigin(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_Destroying([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorkerDestroyingEventHandler>))] ICoreWebView2SharedWorkerDestroyingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_Destroying(EventRegistrationToken token);
}
