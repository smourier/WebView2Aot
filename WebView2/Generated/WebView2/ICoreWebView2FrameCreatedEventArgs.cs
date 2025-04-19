#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4d6e7b5e-9baa-11eb-a8b3-0242ac130003")]
public partial interface ICoreWebView2FrameCreatedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Frame([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Frame>))] out ICoreWebView2Frame value);
}
