#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("2913da94-833d-4de0-8dca-900fc524a1a4")]
public partial interface ICoreWebView2FaviconChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
