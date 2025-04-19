#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("3c067f9f-5388-4772-8b48-79f7ef1ab37c")]
public partial interface ICoreWebView2SourceChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SourceChangedEventArgs>))] ICoreWebView2SourceChangedEventArgs args);
}
