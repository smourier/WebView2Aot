#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("66833876-edba-5a60-8508-7da64504a9d2")]
public partial interface ICoreWebView2DedicatedWorker
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScriptUri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DedicatedWorkerCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorkerDedicatedWorkerCreatedEventHandler>))] ICoreWebView2DedicatedWorkerDedicatedWorkerCreatedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DedicatedWorkerCreated(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_Destroying([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorkerDestroyingEventHandler>))] ICoreWebView2DedicatedWorkerDestroyingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_Destroying(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_WebMessageReceived([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DedicatedWorkerWebMessageReceivedEventHandler>))] ICoreWebView2DedicatedWorkerWebMessageReceivedEventHandler eventHandler, ref EventRegistrationToken token);
    
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
