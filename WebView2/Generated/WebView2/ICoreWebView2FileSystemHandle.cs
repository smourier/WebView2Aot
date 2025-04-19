#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c65100ac-0de2-5551-a362-23d9bd1d0e1f")]
public partial interface ICoreWebView2FileSystemHandle
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Kind(ref COREWEBVIEW2_FILE_SYSTEM_HANDLE_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Permission(ref COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION value);
}
