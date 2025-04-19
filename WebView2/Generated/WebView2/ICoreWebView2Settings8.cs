#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9e6b0e8f-86ad-4e81-8147-a9b5edb68650")]
public partial interface ICoreWebView2Settings8 : ICoreWebView2Settings7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsReputationCheckingRequired(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsReputationCheckingRequired(BOOL value);
}
