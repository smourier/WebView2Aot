#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ac52d13f-0d38-475a-9dca-876580d6793e")]
public partial interface ICoreWebView2EnvironmentOptions4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomSchemeRegistrations(out uint count, out nint schemeRegistrations);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCustomSchemeRegistrations(uint count, nint schemeRegistrations);
}
