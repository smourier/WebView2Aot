#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("05ea24bd-6452-4926-9014-4b82b498135d")]
public partial interface ICoreWebView2FocusChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Controller>))] ICoreWebView2Controller sender, IUnknown args);
}
