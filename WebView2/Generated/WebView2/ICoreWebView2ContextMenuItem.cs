#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7aed49e3-a93f-497a-811c-749c6b6b6c65")]
public partial interface ICoreWebView2ContextMenuItem
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Label(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CommandId(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ShortcutKeyDescription(out PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Icon(out IStream value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Kind(ref COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsEnabled(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsEnabled(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsChecked(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsChecked(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Children([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuItemCollection>))] out ICoreWebView2ContextMenuItemCollection value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_CustomItemSelected([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CustomItemSelectedEventHandler>))] ICoreWebView2CustomItemSelectedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_CustomItemSelected(EventRegistrationToken token);
}
