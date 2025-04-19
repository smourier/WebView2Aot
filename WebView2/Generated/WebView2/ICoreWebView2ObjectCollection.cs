#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("5cfec11c-25bd-4e8d-9e1a-7acdaeeec047")]
public partial interface ICoreWebView2ObjectCollection : ICoreWebView2ObjectCollectionView
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveValueAtIndex(uint index);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertValueAtIndex(uint index, IUnknown value);
}
