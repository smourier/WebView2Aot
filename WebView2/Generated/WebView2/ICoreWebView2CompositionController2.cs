#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0b6a3d24-49cb-4806-ba20-b5e0734a7b26")]
public partial interface ICoreWebView2CompositionController2 : ICoreWebView2CompositionController
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AutomationProvider(out IUnknown value);
}
