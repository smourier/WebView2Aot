#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("364471e7-f2be-4910-bdba-d72077d51c4b")]
public partial interface ICoreWebView2ContentLoadingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContentLoadingEventArgs>))] ICoreWebView2ContentLoadingEventArgs args);
}
