#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9570570e-4d76-4361-9ee1-f04d0dbdfb1e")]
public partial interface ICoreWebView2CompositionController3 : ICoreWebView2CompositionController2
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
