#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0eb34dc9-9f91-41e1-8639-95cd5943906b")]
public partial interface ICoreWebView2_16 : ICoreWebView2_15
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Print([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrintSettings>))] ICoreWebView2PrintSettings printSettings, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrintCompletedHandler>))] ICoreWebView2PrintCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowPrintUI(COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrintToPdfStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrintSettings>))] ICoreWebView2PrintSettings printSettings, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrintToPdfStreamCompletedHandler>))] ICoreWebView2PrintToPdfStreamCompletedHandler handler);
}
