#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f4af0c39-44b9-40e9-8b11-0484cfb9e0a1")]
public partial interface ICoreWebView2ProcessInfosChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Environment>))] ICoreWebView2Environment sender, IUnknown args);
}
