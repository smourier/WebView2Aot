#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("06fc7ab7-c90c-4297-9389-33ca01cf6d5e")]
public partial interface ICoreWebView2WebMessageReceivedEventArgs2 : ICoreWebView2WebMessageReceivedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AdditionalObjects([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ObjectCollectionView>))] out ICoreWebView2ObjectCollectionView value);
}
