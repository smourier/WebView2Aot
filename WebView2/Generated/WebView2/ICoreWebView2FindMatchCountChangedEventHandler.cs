#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("da0d6827-4254-5b10-a6d9-412076afc9f3")]
public partial interface ICoreWebView2FindMatchCountChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Find>))] ICoreWebView2Find sender, IUnknown args);
}
