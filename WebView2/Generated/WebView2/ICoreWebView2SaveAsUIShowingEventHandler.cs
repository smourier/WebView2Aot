#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("6baa177e-3a2e-5ccf-9a13-fad676cd0522")]
public partial interface ICoreWebView2SaveAsUIShowingEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SaveAsUIShowingEventArgs>))] ICoreWebView2SaveAsUIShowingEventArgs args);
}
