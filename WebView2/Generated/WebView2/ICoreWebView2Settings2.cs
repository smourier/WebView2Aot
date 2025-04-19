#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ee9a0f68-f46c-4e32-ac23-ef8cac224d2a")]
public partial interface ICoreWebView2Settings2 : ICoreWebView2Settings
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserAgent(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UserAgent(PWSTR value);
}
