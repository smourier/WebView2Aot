#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c979903e-d4ca-4228-92eb-47ee3fa96eab")]
public partial interface ICoreWebView2Controller2 : ICoreWebView2Controller
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultBackgroundColor(ref COREWEBVIEW2_COLOR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultBackgroundColor(COREWEBVIEW2_COLOR value);
}
