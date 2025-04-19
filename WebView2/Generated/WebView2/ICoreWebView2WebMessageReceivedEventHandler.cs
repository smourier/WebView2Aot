#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("57213f19-00e6-49fa-8e07-898ea01ecbd2")]
public partial interface ICoreWebView2WebMessageReceivedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebMessageReceivedEventArgs>))] ICoreWebView2WebMessageReceivedEventArgs args);
}
