#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("7b4c7906-a1aa-4cb4-b723-db09f813d541")]
public partial interface ICoreWebView2Profile7 : ICoreWebView2Profile6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddBrowserExtension(PWSTR extensionFolderPath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProfileAddBrowserExtensionCompletedHandler>))] ICoreWebView2ProfileAddBrowserExtensionCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBrowserExtensions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler>))] ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler handler);
}
