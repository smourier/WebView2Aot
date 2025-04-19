#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f562a2f5-c415-45cf-b909-d4b7c1e276d3")]
public partial interface ICoreWebView2ContextMenuItemCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuItem>))] out ICoreWebView2ContextMenuItem value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveValueAtIndex(uint index);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuItem>))] ICoreWebView2ContextMenuItem value);
}
