#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f0913dc6-a0ec-42ef-9805-91dff3a2966a")]
public partial interface ICoreWebView2Environment11 : ICoreWebView2Environment10
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FailureReportFolderPath(ref PWSTR value);
}
