#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b5a86092-df50-5b4f-a17b-6c8f8b40b771")]
public partial interface ICoreWebView2_25 : ICoreWebView2_24
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_SaveAsUIShowing([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SaveAsUIShowingEventHandler>))] ICoreWebView2SaveAsUIShowingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_SaveAsUIShowing(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowSaveAsUI([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ShowSaveAsUICompletedHandler>))] ICoreWebView2ShowSaveAsUICompletedHandler handler);
}
