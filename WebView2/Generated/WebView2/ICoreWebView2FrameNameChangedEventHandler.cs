#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("435c7dc8-9baa-11eb-a8b3-0242ac130003")]
public partial interface ICoreWebView2FrameNameChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] ICoreWebView2Frame sender, IUnknown args);
}
