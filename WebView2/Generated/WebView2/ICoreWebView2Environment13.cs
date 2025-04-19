#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("af641f58-72b2-11ee-b962-0242ac120002")]
public partial interface ICoreWebView2Environment13 : ICoreWebView2Environment12
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcessExtendedInfos([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2GetProcessExtendedInfosCompletedHandler>))] ICoreWebView2GetProcessExtendedInfosCompletedHandler handler);
}
