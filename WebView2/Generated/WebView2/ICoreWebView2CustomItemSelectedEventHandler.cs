#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("49e1d0bc-fe9e-4481-b7c2-32324aa21998")]
public partial interface ICoreWebView2CustomItemSelectedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuItem>))] ICoreWebView2ContextMenuItem sender, IUnknown args);
}
