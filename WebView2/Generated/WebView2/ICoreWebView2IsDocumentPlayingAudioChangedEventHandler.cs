#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5def109a-2f4b-49fa-b7f6-11c39e513328")]
public partial interface ICoreWebView2IsDocumentPlayingAudioChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
