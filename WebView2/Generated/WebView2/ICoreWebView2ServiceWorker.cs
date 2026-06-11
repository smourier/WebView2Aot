#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("245a7bb7-7c31-582d-95ee-0f2d99d2f5b0")]
public partial interface ICoreWebView2ServiceWorker
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScriptUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_Destroying([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerDestroyingEventHandler>))] ICoreWebView2ServiceWorkerDestroyingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_Destroying(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_WebMessageReceived([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ServiceWorkerWebMessageReceivedEventHandler>))] ICoreWebView2ServiceWorkerWebMessageReceivedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_WebMessageReceived(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostWebMessageAsJson(PWSTR webMessageAsJson);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostWebMessageAsString(PWSTR webMessageAsString);
}
