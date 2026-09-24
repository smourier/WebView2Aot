#nullable enable
namespace WebView2;

public static partial class Functions
{
    public static int CompareBrowserVersions(string? version1, string? version2)
    {
        int result;
        using var version1Str = new DirectN.Extensions.Utilities.Pwstr(version1);
        using var version2Str = new DirectN.Extensions.Utilities.Pwstr(version2);
        int resultNative = default;
        CompareBrowserVersions(version1Str, version2Str, ref resultNative).ThrowOnError();
        result = resultNative;
        return result;
    }

    public static Task<IComObject<ICoreWebView2Environment>?> CreateCoreWebView2EnvironmentAsync()
    {
        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2Environment>?>();
        var hr = CreateCoreWebView2Environment(new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2Environment>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static Task<IComObject<ICoreWebView2Environment>?> CreateCoreWebView2EnvironmentWithOptionsAsync(string? browserExecutableFolder, string? userDataFolder, ICoreWebView2EnvironmentOptions? environmentOptions)
    {
        using var browserExecutableFolderStr = new DirectN.Extensions.Utilities.Pwstr(browserExecutableFolder);
        using var userDataFolderStr = new DirectN.Extensions.Utilities.Pwstr(userDataFolder);
        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2Environment>?>();
        var hr = CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolderStr, userDataFolderStr, environmentOptions, new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2Environment>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static string? GetAvailableCoreWebView2BrowserVersionString(string? browserExecutableFolder)
    {
        string? versionInfo;
        using var browserExecutableFolderStr = new DirectN.Extensions.Utilities.Pwstr(browserExecutableFolder);
        GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolderStr, out PWSTR versionInfoNative).ThrowOnError();
        versionInfo = versionInfoNative.ToStringAndDispose();
        return versionInfo;
    }

    public static string? GetAvailableCoreWebView2BrowserVersionStringWithOptions(string? browserExecutableFolder, ICoreWebView2EnvironmentOptions? environmentOptions)
    {
        string? versionInfo;
        using var browserExecutableFolderStr = new DirectN.Extensions.Utilities.Pwstr(browserExecutableFolder);
        GetAvailableCoreWebView2BrowserVersionStringWithOptions(browserExecutableFolderStr, environmentOptions, out PWSTR versionInfoNative).ThrowOnError();
        versionInfo = versionInfoNative.ToStringAndDispose();
        return versionInfo;
    }
}
