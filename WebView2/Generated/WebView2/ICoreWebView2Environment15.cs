#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("2ac5ebfb-e654-5961-a667-7971885c7b27")]
public partial interface ICoreWebView2Environment15 : ICoreWebView2Environment14
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFindOptions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FindOptions>))] out ICoreWebView2FindOptions value);
}
