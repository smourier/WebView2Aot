#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("c4980dea-587b-43b9-8143-3ef3bf552d95")]
public partial interface ICoreWebView2_21 : ICoreWebView2_20
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteScriptWithResult(PWSTR javaScript, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ExecuteScriptWithResultCompletedHandler>))] ICoreWebView2ExecuteScriptWithResultCompletedHandler handler);
}
