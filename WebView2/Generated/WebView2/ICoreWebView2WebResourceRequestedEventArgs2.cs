#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9c562c24-b219-4d7f-92f6-b187fbbadd56")]
public partial interface ICoreWebView2WebResourceRequestedEventArgs2 : ICoreWebView2WebResourceRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequestedSourceKind(ref COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS value);
}
