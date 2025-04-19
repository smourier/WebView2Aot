#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f9a2976e-d34e-44fc-adee-81b6b57ca914")]
public partial interface ICoreWebView2NewBrowserVersionAvailableEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Environment>))] ICoreWebView2Environment sender, IUnknown args);
}
