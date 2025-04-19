#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e562e4f0-d7fa-43ac-8d71-c05150499f00")]
public partial interface ICoreWebView2Settings
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsScriptEnabled(ref BOOL isScriptEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsScriptEnabled(BOOL isScriptEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsWebMessageEnabled(ref BOOL isWebMessageEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsWebMessageEnabled(BOOL isWebMessageEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AreDefaultScriptDialogsEnabled(ref BOOL areDefaultScriptDialogsEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AreDefaultScriptDialogsEnabled(BOOL areDefaultScriptDialogsEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsStatusBarEnabled(ref BOOL isStatusBarEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsStatusBarEnabled(BOOL isStatusBarEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AreDevToolsEnabled(ref BOOL areDevToolsEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AreDevToolsEnabled(BOOL areDevToolsEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AreDefaultContextMenusEnabled(ref BOOL enabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AreDefaultContextMenusEnabled(BOOL enabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AreHostObjectsAllowed(ref BOOL allowed);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AreHostObjectsAllowed(BOOL allowed);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsZoomControlEnabled(ref BOOL enabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsZoomControlEnabled(BOOL enabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsBuiltInErrorPageEnabled(ref BOOL enabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsBuiltInErrorPageEnabled(BOOL enabled);
}
