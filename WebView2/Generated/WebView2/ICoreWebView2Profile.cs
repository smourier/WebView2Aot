#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("79110ad3-cd5d-4373-8bc3-c60658f17a5f")]
public partial interface ICoreWebView2Profile
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProfileName(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsInPrivateModeEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProfilePath(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultDownloadFolderPath(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultDownloadFolderPath(PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PreferredColorScheme(ref COREWEBVIEW2_PREFERRED_COLOR_SCHEME value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PreferredColorScheme(COREWEBVIEW2_PREFERRED_COLOR_SCHEME value);
}
