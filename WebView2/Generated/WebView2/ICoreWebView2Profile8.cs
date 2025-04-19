#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("fbf70c2f-eb1f-4383-85a0-163e92044011")]
public partial interface ICoreWebView2Profile8 : ICoreWebView2Profile7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_Deleted([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProfileDeletedEventHandler>))] ICoreWebView2ProfileDeletedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_Deleted(EventRegistrationToken token);
}
