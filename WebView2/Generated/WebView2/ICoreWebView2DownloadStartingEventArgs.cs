#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e99bbe21-43e9-4544-a732-282764eafa60")]
public partial interface ICoreWebView2DownloadStartingEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DownloadOperation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DownloadOperation>))] out ICoreWebView2DownloadOperation downloadOperation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cancel(ref BOOL cancel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Cancel(BOOL cancel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ResultFilePath(ref PWSTR resultFilePath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ResultFilePath(PWSTR resultFilePath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL handled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL handled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
}
