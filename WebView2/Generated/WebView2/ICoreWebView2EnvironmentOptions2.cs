#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ff85c98a-1ba7-4a6b-90c8-2b752c89e9e2")]
public partial interface ICoreWebView2EnvironmentOptions2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExclusiveUserDataFolderAccess(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ExclusiveUserDataFolderAccess(BOOL value);
}
