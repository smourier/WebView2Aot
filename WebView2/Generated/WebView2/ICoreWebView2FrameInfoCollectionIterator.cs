#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("1bf89e2d-1b2b-4629-b28f-05099b41bb03")]
public partial interface ICoreWebView2FrameInfoCollectionIterator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HasCurrent(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfo>))] out ICoreWebView2FrameInfo value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveNext(ref BOOL value);
}
