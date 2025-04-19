#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("06c991d8-9e7e-11ed-a8fc-0242ac120002")]
public partial interface ICoreWebView2ControllerOptions2 : ICoreWebView2ControllerOptions
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScriptLocale(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ScriptLocale(PWSTR value);
}
