#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ee503a63-c1e2-4fbf-8a4d-824e95f8bb13")]
public partial interface ICoreWebView2EnvironmentInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutomationProviderForWindow(HWND hwnd, out IUnknown provider);
}
