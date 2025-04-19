#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("d6eb91dd-c3d2-45e5-bd29-6dc2bc4de9cf")]
public partial interface ICoreWebView2Environment8 : ICoreWebView2Environment7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ProcessInfosChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessInfosChangedEventHandler>))] ICoreWebView2ProcessInfosChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ProcessInfosChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcessInfos([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessInfoCollection>))] out ICoreWebView2ProcessInfoCollection value);
}
