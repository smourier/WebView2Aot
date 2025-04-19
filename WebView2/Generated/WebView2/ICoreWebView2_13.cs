#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f75f09a8-667e-4983-88d6-c8773f315e84")]
public partial interface ICoreWebView2_13 : ICoreWebView2_12
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Profile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Profile>))] out ICoreWebView2Profile value);
}
