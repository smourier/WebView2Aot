#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("1f00663f-af8c-4782-9cdd-dd01c52e34cb")]
public partial interface ICoreWebView2BrowserProcessExitedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BrowserProcessExitKind(ref COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BrowserProcessId(ref uint value);
}
