#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7ef7ffa0-fac5-462c-b189-3d9edbe575da")]
public partial interface ICoreWebView2BrowserExtension
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BrowserExtensionRemoveCompletedHandler>))] ICoreWebView2BrowserExtensionRemoveCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable(BOOL isEnabled, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BrowserExtensionEnableCompletedHandler>))] ICoreWebView2BrowserExtensionEnableCompletedHandler handler);
}
