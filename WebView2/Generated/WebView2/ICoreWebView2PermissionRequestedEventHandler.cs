#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("15e1c6a3-c72a-4df3-91d7-d097fbec6bfd")]
public partial interface ICoreWebView2PermissionRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PermissionRequestedEventArgs>))] ICoreWebView2PermissionRequestedEventArgs args);
}
