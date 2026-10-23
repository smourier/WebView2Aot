#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e00e3c7f-d6d3-5e64-b7ab-581b6316b227")]
public partial interface ICoreWebView2ProcessFailedEventArgs4 : ICoreWebView2ProcessFailedEventArgs3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CrashReport([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CrashReport>))] out ICoreWebView2CrashReport value);
}
