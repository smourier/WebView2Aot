#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("d4c185fe-c81c-4989-97af-2d3fa7ab5651")]
public partial interface ICoreWebView2NewWindowRequestedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NewWindowRequestedEventArgs>))] ICoreWebView2NewWindowRequestedEventArgs args);
}
