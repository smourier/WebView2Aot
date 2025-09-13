#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("62e50381-5bf5-51a8-aae0-f20a3a9c8a90")]
public partial interface ICoreWebView2_28 : ICoreWebView2_27
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Find([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Find>))] out ICoreWebView2Find value);
}
