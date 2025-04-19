#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4d00c0d1-9434-4eb6-8078-8697a560334f")]
public partial interface ICoreWebView2Controller
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsVisible(ref BOOL isVisible);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsVisible(BOOL isVisible);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bounds(ref RECT bounds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Bounds(RECT bounds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ZoomFactor(ref double zoomFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ZoomFactor(double zoomFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ZoomFactorChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ZoomFactorChangedEventHandler>))] ICoreWebView2ZoomFactorChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ZoomFactorChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBoundsAndZoomFactor(RECT bounds, double zoomFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON reason);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_MoveFocusRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2MoveFocusRequestedEventHandler>))] ICoreWebView2MoveFocusRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_MoveFocusRequested(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_GotFocus([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FocusChangedEventHandler>))] ICoreWebView2FocusChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_GotFocus(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_LostFocus([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FocusChangedEventHandler>))] ICoreWebView2FocusChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_LostFocus(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_AcceleratorKeyPressed([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2AcceleratorKeyPressedEventHandler>))] ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_AcceleratorKeyPressed(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ParentWindow(ref HWND parentWindow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ParentWindow(HWND parentWindow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyParentWindowPositionChanged();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CoreWebView2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] out ICoreWebView2 coreWebView2);
}
