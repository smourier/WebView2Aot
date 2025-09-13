#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("1512dd5b-5514-4f85-886e-21c3a4c9cfe6")]
public partial interface ICoreWebView2NotificationReceivedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SenderOrigin(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Notification([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Notification>))] out ICoreWebView2Notification value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
}
