#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8e9922ce-9c80-42e6-bad7-fcebf291a495")]
public partial interface ICoreWebView2CompositionControllerInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AutomationProvider(out IUnknown provider);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RootVisualTarget(out IUnknown target);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RootVisualTarget(IUnknown target);
}
