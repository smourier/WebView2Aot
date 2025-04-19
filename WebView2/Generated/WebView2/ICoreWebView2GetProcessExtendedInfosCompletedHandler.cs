#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f45e55aa-3bc2-11ee-be56-0242ac120002")]
public partial interface ICoreWebView2GetProcessExtendedInfosCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessExtendedInfoCollection>))] ICoreWebView2ProcessExtendedInfoCollection result);
}
