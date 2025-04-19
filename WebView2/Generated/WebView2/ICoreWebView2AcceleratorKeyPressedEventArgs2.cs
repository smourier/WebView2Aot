#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("03b2c8c8-7799-4e34-bd66-ed26aa85f2bf")]
public partial interface ICoreWebView2AcceleratorKeyPressedEventArgs2 : ICoreWebView2AcceleratorKeyPressedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsBrowserAcceleratorKeyEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsBrowserAcceleratorKeyEnabled(BOOL value);
}
