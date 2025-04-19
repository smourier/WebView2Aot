#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5c19e9e0-092f-486b-affa-ca8231913039")]
public partial interface ICoreWebView2WindowCloseRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
