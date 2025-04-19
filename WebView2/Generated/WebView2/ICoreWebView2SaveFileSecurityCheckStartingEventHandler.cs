#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7899576c-19e3-57c8-b7d1-55808292de57")]
public partial interface ICoreWebView2SaveFileSecurityCheckStartingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SaveFileSecurityCheckStartingEventArgs>))] ICoreWebView2SaveFileSecurityCheckStartingEventArgs args);
}
