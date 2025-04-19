#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("cb56846c-4168-4d53-b04f-03b6d6796ff2")]
public partial interface ICoreWebView2Settings4 : ICoreWebView2Settings3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsPasswordAutosaveEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsPasswordAutosaveEnabled(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsGeneralAutofillEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsGeneralAutofillEnabled(BOOL value);
}
