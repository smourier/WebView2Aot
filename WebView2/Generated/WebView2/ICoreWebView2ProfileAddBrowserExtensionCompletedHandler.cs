#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("df1aab27-82b9-4ab6-aae8-017a49398c14")]
public partial interface ICoreWebView2ProfileAddBrowserExtensionCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BrowserExtension>))] ICoreWebView2BrowserExtension result);
}
