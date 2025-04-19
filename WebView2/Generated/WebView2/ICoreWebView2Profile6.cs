#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("bd82fa6a-1d65-4c33-b2b4-0393020cc61b")]
public partial interface ICoreWebView2Profile6 : ICoreWebView2Profile5
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
