#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ab667428-094d-5fd1-b480-8b4c0fdbdf2f")]
public partial interface ICoreWebView2ProcessFailedEventArgs3 : ICoreWebView2ProcessFailedEventArgs2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FailureSourceModulePath(out PWSTR value);
}
