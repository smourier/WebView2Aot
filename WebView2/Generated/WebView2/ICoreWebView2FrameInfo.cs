#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("da86b8a1-bdf3-4f11-9955-528cefa59727")]
public partial interface ICoreWebView2FrameInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Source(out PWSTR value);
}
