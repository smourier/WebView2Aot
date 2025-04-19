#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("79c24d83-09a3-45ae-9418-487f32a58740")]
public partial interface ICoreWebView2_7 : ICoreWebView2_6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrintToPdf(PWSTR ResultFilePath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrintSettings>))] ICoreWebView2PrintSettings printSettings, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrintToPdfCompletedHandler>))] ICoreWebView2PrintToPdfCompletedHandler handler);
}
