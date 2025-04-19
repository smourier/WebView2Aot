#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("499aadac-d92c-4589-8a75-111bfc167795")]
public partial interface ICoreWebView2_6 : ICoreWebView2_5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenTaskManagerWindow();
}
