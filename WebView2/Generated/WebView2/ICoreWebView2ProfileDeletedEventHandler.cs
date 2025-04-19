#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("df35055d-772e-4dbe-b743-5fbf74a2b258")]
public partial interface ICoreWebView2ProfileDeletedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Profile>))] ICoreWebView2Profile sender, IUnknown args);
}
