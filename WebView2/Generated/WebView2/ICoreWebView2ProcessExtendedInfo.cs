#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("af4c4c2e-45db-11ee-be56-0242ac120002")]
public partial interface ICoreWebView2ProcessExtendedInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProcessInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessInfo>))] out ICoreWebView2ProcessInfo processInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AssociatedFrameInfos([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FrameInfoCollection>))] out ICoreWebView2FrameInfoCollection frames);
}
