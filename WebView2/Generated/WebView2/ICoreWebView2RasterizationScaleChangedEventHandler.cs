#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("9c98c8b1-ac53-427e-a345-3049b5524bbe")]
public partial interface ICoreWebView2RasterizationScaleChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Controller>))] ICoreWebView2Controller sender, IUnknown args);
}
