#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("20944379-6dcf-41d6-a0a0-abc0fc50de0d")]
public partial interface ICoreWebView2Environment4 : ICoreWebView2Environment3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutomationProviderForWindow(HWND hwnd, out IUnknown value);
}
