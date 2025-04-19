#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f5f2b923-953e-4042-9f95-f3a118e1afd4")]
public partial interface ICoreWebView2DocumentTitleChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
