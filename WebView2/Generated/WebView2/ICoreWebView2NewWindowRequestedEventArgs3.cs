#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("842bed3c-6ad6-4dd9-b938-28c96667ad66")]
public partial interface ICoreWebView2NewWindowRequestedEventArgs3 : ICoreWebView2NewWindowRequestedEventArgs2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OriginalSourceFrameInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfo>))] out ICoreWebView2FrameInfo value);
}
