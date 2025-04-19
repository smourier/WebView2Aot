#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("db75dfc7-a857-4632-a398-6969dde26c0a")]
public partial interface ICoreWebView2_22 : ICoreWebView2_21
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddWebResourceRequestedFilterWithRequestSourceKinds(PWSTR uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveWebResourceRequestedFilterWithRequestSourceKinds(PWSTR uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds);
}
