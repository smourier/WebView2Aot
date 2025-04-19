#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ac52d13f-0d38-475a-9dca-876580d6793e")]
public partial interface ICoreWebView2EnvironmentOptions4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomSchemeRegistrations(ref uint count, ref ICoreWebView2CustomSchemeRegistration schemeRegistrations);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCustomSchemeRegistrations(uint count, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CustomSchemeRegistration>))] out ICoreWebView2CustomSchemeRegistration schemeRegistrations);
}
