#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("188782dc-92aa-4732-ab3c-fcc59f6f68b9")]
public partial interface ICoreWebView2Frame4 : ICoreWebView2Frame3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostSharedBufferToScript([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedBuffer>))] ICoreWebView2SharedBuffer sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, PWSTR additionalDataAsJson);
}
