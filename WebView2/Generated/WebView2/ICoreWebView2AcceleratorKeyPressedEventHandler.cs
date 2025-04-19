#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b29c7e28-fa79-41a8-8e44-65811c76dcb2")]
public partial interface ICoreWebView2AcceleratorKeyPressedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Controller>))] ICoreWebView2Controller sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2AcceleratorKeyPressedEventArgs>))] ICoreWebView2AcceleratorKeyPressedEventArgs args);
}
