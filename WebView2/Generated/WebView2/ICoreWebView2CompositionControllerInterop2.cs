#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("6b47bbe1-2480-4ff8-a5ba-69c2f0b868b3")]
public partial interface ICoreWebView2CompositionControllerInterop2 : ICoreWebView2CompositionControllerInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragEnter(IDataObject dataObject, uint keyState, POINT point, ref uint effect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragLeave();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragOver(uint keyState, POINT point, ref uint effect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Drop(IDataObject dataObject, uint keyState, POINT point, ref uint effect);
}
