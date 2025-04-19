#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("02fab84b-1428-4fb7-ad45-1b2e64736184")]
public partial interface ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CompositionController>))] ICoreWebView2CompositionController result);
}
