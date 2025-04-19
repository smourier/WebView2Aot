#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("333353b8-48bf-4449-8fcc-22697faf5753")]
public partial interface ICoreWebView2RegionRectCollectionView
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, ref RECT value);
}
