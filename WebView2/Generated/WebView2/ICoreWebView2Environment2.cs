#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("41f3632b-5ef4-404f-ad82-2d606c5a9a21")]
public partial interface ICoreWebView2Environment2 : ICoreWebView2Environment
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateWebResourceRequest(PWSTR uri, PWSTR Method, IStream postData, PWSTR Headers, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceRequest>))] out ICoreWebView2WebResourceRequest value);
}
