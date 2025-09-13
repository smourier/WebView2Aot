#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("21eb052f-ad39-555e-824a-c87b091d4d36")]
public partial interface ICoreWebView2ControllerOptions4 : ICoreWebView2ControllerOptions3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowHostInputProcessing(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowHostInputProcessing(BOOL value);
}
