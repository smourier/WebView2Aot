#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("402b99cd-a0cc-4fa5-b7a5-51d86a1d2339")]
public partial interface ICoreWebView2ProcessInfoCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessInfo>))] out ICoreWebView2ProcessInfo value);
}
