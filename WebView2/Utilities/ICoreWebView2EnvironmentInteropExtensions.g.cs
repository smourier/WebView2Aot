#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentInteropExtensions
{
    public static IComObject<IUnknown>? GetAutomationProviderForWindow(this ICoreWebView2EnvironmentInterop instance, HWND hwnd)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<IUnknown>? provider;
        instance.GetAutomationProviderForWindow(hwnd, out IUnknown providerNative).ThrowOnError();
        provider = providerNative != null ? new ComObject<IUnknown>(providerNative) : null;
        return provider;
    }

    public static IComObject<IUnknown>? GetAutomationProviderForWindow(this IComObject<ICoreWebView2EnvironmentInterop> instance, HWND hwnd) => GetAutomationProviderForWindow(instance?.Object!, hwnd);
}
