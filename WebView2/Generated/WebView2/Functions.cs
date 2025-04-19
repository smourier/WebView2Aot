#nullable enable
namespace WebView2;

public static partial class Functions
{
    [LibraryImport("WebView2Loader")]
    [PreserveSig]
    public static partial HRESULT CompareBrowserVersions(PWSTR version1, PWSTR version2, ref int result);
    
    [LibraryImport("WebView2Loader")]
    [PreserveSig]
    public static partial HRESULT CreateCoreWebView2Environment([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler>))] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);
    
    [LibraryImport("WebView2Loader")]
    [PreserveSig]
    public static partial HRESULT CreateCoreWebView2EnvironmentWithOptions(PWSTR browserExecutableFolder, PWSTR userDataFolder, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2EnvironmentOptions>))] ICoreWebView2EnvironmentOptions environmentOptions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler>))] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);
    
    [LibraryImport("WebView2Loader")]
    [PreserveSig]
    public static partial HRESULT GetAvailableCoreWebView2BrowserVersionString(PWSTR browserExecutableFolder, ref PWSTR versionInfo);
    
    [LibraryImport("WebView2Loader")]
    [PreserveSig]
    public static partial HRESULT GetAvailableCoreWebView2BrowserVersionStringWithOptions(PWSTR browserExecutableFolder, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2EnvironmentOptions>))] ICoreWebView2EnvironmentOptions environmentOptions, ref PWSTR versionInfo);
}
