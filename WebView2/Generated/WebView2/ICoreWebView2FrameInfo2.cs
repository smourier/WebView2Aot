#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("56f85cfa-72c4-11ee-b962-0242ac120002")]
public partial interface ICoreWebView2FrameInfo2 : ICoreWebView2FrameInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ParentFrameInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfo>))] out ICoreWebView2FrameInfo frameInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrameId(ref uint id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrameKind(ref COREWEBVIEW2_FRAME_KIND kind);
}
