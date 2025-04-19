#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8f834154-d38e-4d90-affb-6800a7272839")]
public partial interface ICoreWebView2FrameInfoCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIterator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfoCollectionIterator>))] out ICoreWebView2FrameInfoCollectionIterator value);
}
