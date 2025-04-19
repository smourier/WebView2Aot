#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("d1db483d-6796-4b8b-80fc-13712bb716f4")]
public partial interface ICoreWebView2WebResourceResponseReceivedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Request([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceRequest>))] out ICoreWebView2WebResourceRequest value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Response([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceResponseView>))] out ICoreWebView2WebResourceResponseView value);
}
