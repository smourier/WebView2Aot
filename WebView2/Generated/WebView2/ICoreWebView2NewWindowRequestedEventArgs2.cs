#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("bbc7baed-74c6-4c92-b63a-7f5aeae03de3")]
public partial interface ICoreWebView2NewWindowRequestedEventArgs2 : ICoreWebView2NewWindowRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out PWSTR value);
}
