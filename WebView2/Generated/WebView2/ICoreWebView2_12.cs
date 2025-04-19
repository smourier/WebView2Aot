#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("35d69927-bcfa-4566-9349-6b3e0d154cac")]
public partial interface ICoreWebView2_12 : ICoreWebView2_11
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_StatusBarTextChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2StatusBarTextChangedEventHandler>))] ICoreWebView2StatusBarTextChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_StatusBarTextChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StatusBarText(ref PWSTR value);
}
