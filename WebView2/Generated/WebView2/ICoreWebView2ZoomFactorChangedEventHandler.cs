#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b52d71d6-c4df-4543-a90c-64a3e60f38cb")]
public partial interface ICoreWebView2ZoomFactorChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Controller>))] ICoreWebView2Controller sender, IUnknown args);
}
