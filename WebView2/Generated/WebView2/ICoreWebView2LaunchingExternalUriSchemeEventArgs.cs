#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("07d1a6c3-7175-4ba1-9306-e593ca07e46c")]
public partial interface ICoreWebView2LaunchingExternalUriSchemeEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Uri(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InitiatingOrigin(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsUserInitiated(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cancel(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Cancel(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral value);
}
