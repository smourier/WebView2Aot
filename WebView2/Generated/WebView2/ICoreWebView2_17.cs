#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("702e75d4-fd44-434d-9d70-1a68a6b1192a")]
public partial interface ICoreWebView2_17 : ICoreWebView2_16
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostSharedBufferToScript([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedBuffer>))] ICoreWebView2SharedBuffer sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, PWSTR additionalDataAsJson);
}
