#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("74f712e0-8165-43a9-a13f-0cce597e75df")]
public partial interface ICoreWebView2LaunchingExternalUriSchemeEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2LaunchingExternalUriSchemeEventArgs>))] ICoreWebView2LaunchingExternalUriSchemeEventArgs args);
}
