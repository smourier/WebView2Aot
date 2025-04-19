#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("fdb5ab74-af33-4854-84f0-0a631deb5eba")]
public partial interface ICoreWebView2Settings3 : ICoreWebView2Settings2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AreBrowserAcceleratorKeysEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AreBrowserAcceleratorKeysEnabled(BOOL value);
}
