#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("453e667f-12c7-49d4-be6d-ddbe7956f57a")]
public partial interface ICoreWebView2WebResourceRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Request([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceRequest>))] out ICoreWebView2WebResourceRequest request);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Response([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceResponse>))] out ICoreWebView2WebResourceResponse response);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Response([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceResponse>))] ICoreWebView2WebResourceResponse response);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ResourceContext(ref COREWEBVIEW2_WEB_RESOURCE_CONTEXT context);
}
