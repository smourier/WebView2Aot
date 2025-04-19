#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3df9b733-b9ae-4a15-86b4-eb9ee9826469")]
public partial interface ICoreWebView2CompositionController
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RootVisualTarget(out IUnknown target);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RootVisualTarget(IUnknown target);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendMouseInput(COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, uint mouseData, POINT point);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendPointerInput(COREWEBVIEW2_POINTER_EVENT_KIND eventKind, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PointerInfo>))] ICoreWebView2PointerInfo pointerInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Cursor(ref HCURSOR cursor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SystemCursorId(ref uint systemCursorId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_CursorChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CursorChangedEventHandler>))] ICoreWebView2CursorChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_CursorChanged(EventRegistrationToken token);
}
