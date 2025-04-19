#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a1d309ee-c03f-11eb-8529-0242ac130003")]
public partial interface ICoreWebView2ContextMenuRequestedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MenuItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuItemCollection>))] out ICoreWebView2ContextMenuItemCollection value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ContextMenuTarget([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuTarget>))] out ICoreWebView2ContextMenuTarget value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Location(ref POINT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SelectedCommandId(int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SelectedCommandId(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Handled(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeferral([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Deferral>))] out ICoreWebView2Deferral deferral);
}
