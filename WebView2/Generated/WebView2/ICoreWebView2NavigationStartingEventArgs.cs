#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5b495469-e119-438a-9b18-7604f25f2e49")]
public partial interface ICoreWebView2NavigationStartingEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Uri(ref PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsUserInitiated(ref BOOL isUserInitiated);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsRedirected(ref BOOL isRedirected);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequestHeaders([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HttpRequestHeaders>))] out ICoreWebView2HttpRequestHeaders requestHeaders);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cancel(ref BOOL cancel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Cancel(BOOL cancel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NavigationId(ref ulong navigationId);
}
