#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("4e8a3389-c9d8-4bd2-b6b5-124fee6cc14d")]
public partial interface ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Environment>))] ICoreWebView2Environment result);
}
