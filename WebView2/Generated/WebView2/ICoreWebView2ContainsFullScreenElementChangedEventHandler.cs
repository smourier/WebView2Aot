#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e45d98b1-afef-45be-8baf-6c7728867f73")]
public partial interface ICoreWebView2ContainsFullScreenElementChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
