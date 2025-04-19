#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c10e7f7b-b585-46f0-a623-8befbf3e4ee0")]
public partial interface ICoreWebView2Deferral
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Complete();
}
