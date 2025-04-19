#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a5e3b0d0-10df-4156-bfad-3b43867acac6")]
public partial interface ICoreWebView2StatusBarTextChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
