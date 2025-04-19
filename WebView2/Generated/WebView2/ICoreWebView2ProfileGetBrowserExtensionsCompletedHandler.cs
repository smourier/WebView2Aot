#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("fce16a1c-f107-4601-8b75-fc4940ae25d0")]
public partial interface ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BrowserExtensionList>))] ICoreWebView2BrowserExtensionList result);
}
