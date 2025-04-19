#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("fa504257-a216-4911-a860-fe8825712861")]
public partial interface ICoreWebView2BrowserProcessExitedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Environment>))] ICoreWebView2Environment sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BrowserProcessExitedEventArgs>))] ICoreWebView2BrowserProcessExitedEventArgs args);
}
