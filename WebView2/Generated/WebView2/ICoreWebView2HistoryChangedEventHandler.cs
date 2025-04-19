#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c79a420c-efd9-4058-9295-3e8b4bcab645")]
public partial interface ICoreWebView2HistoryChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
