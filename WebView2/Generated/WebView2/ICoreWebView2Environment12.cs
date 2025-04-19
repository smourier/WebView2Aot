#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f503db9b-739f-48dd-b151-fdfcf253f54e")]
public partial interface ICoreWebView2Environment12 : ICoreWebView2Environment11
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSharedBuffer(ulong Size, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedBuffer>))] out ICoreWebView2SharedBuffer value);
}
