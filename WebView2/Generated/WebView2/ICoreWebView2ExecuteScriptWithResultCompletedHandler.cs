#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("1bb5317b-8238-4c67-a7ff-baf6558f289d")]
public partial interface ICoreWebView2ExecuteScriptWithResultCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ExecuteScriptResult>))] ICoreWebView2ExecuteScriptResult result);
}
