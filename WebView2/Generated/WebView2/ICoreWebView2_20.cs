#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b4bc1926-7305-11ee-b962-0242ac120002")]
public partial interface ICoreWebView2_20 : ICoreWebView2_19
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrameId(ref uint value);
}
