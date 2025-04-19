#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("2ef3d2dc-bd5f-4f4d-90af-fd67798f0c2f")]
public partial interface ICoreWebView2BrowserExtensionList
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2BrowserExtension>))] out ICoreWebView2BrowserExtension value);
}
