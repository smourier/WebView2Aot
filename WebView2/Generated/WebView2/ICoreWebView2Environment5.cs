#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("319e423d-e0d7-4b8d-9254-ae9475de9b17")]
public partial interface ICoreWebView2Environment5 : ICoreWebView2Environment4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_BrowserProcessExited([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BrowserProcessExitedEventHandler>))] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_BrowserProcessExited(EventRegistrationToken token);
}
