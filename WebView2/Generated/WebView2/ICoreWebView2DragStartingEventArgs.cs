#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("8b8d9c7e-2f1a-4e6b-9d5a-3c8f7b9e1a2d")]
public partial interface ICoreWebView2DragStartingEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowedDropEffects(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Data(out IDataObject value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Position(ref POINT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral value);
}
