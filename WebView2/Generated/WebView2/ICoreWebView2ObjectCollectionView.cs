#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0f36fd87-4f69-4415-98da-888f89fb9a33")]
public partial interface ICoreWebView2ObjectCollectionView
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, out IUnknown value);
}
