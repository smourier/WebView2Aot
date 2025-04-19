#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("99d199c4-7305-11ee-b962-0242ac120002")]
public partial interface ICoreWebView2Frame5 : ICoreWebView2Frame4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrameId(ref uint value);
}
