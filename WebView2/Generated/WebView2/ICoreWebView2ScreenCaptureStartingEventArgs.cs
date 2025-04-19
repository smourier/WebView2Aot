#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("892c03fd-aee3-5eba-a1fa-6fd2f6484b2b")]
public partial interface ICoreWebView2ScreenCaptureStartingEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cancel(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Cancel(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OriginalSourceFrameInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfo>))] out ICoreWebView2FrameInfo value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral value);
}
