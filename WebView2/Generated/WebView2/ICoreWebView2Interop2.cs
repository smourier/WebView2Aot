#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b151ad7c-cfb0-4ecf-b9b2-afca868581a6")]
public partial interface ICoreWebView2Interop2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComICoreWebView2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] out ICoreWebView2 coreWebView2);
}
