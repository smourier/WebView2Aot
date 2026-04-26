namespace WebView2;

[GeneratedComInterface, Guid("e6041d7f-18ac-4654-a04e-8b3f81251c33")]
public partial interface ICoreWebView2ExperimentalCompositionController4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AutomationProvider([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUnknown>))] out IUnknown value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCoreWebView2PointerInfoFromPointerId(uint PointerId, HWND ParentWindow, D2D_MATRIX_4X4_F transform, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PointerInfo>))] out ICoreWebView2PointerInfo value);
}
