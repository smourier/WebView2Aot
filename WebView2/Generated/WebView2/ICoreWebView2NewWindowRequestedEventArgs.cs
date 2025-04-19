#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("34acb11c-fc37-4418-9132-f9c21d1eafb9")]
public partial interface ICoreWebView2NewWindowRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Uri(ref PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_NewWindow([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 newWindow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NewWindow([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] out ICoreWebView2 newWindow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL handled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL handled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsUserInitiated(ref BOOL isUserInitiated);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WindowFeatures([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WindowFeatures>))] out ICoreWebView2WindowFeatures value);
}
