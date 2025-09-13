#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0054f514-9a8e-5876-aed5-30b37f8c86a5")]
public partial interface ICoreWebView2FindActiveMatchIndexChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Find>))] ICoreWebView2Find sender, IUnknown args);
}
