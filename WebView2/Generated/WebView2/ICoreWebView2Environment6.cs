#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("e59ee362-acbd-4857-9a8e-d3644d9459a9")]
public partial interface ICoreWebView2Environment6 : ICoreWebView2Environment5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePrintSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrintSettings>))] out ICoreWebView2PrintSettings value);
}
