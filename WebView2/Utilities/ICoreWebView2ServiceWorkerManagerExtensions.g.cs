#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServiceWorkerManagerExtensions
{
    public static Task<IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>?> GetServiceWorkerRegistrationsAsync(this ICoreWebView2ServiceWorkerManager instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>?>();
        var hr = instance.GetServiceWorkerRegistrations(new CoreWebView2GetServiceWorkerRegistrationsCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static Task<IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>?> GetServiceWorkerRegistrationsForScopeAsync(this ICoreWebView2ServiceWorkerManager instance, string? scopeUri)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var scopeUriStr = new DirectN.Extensions.Utilities.Pwstr(scopeUri);
        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>?>();
        var hr = instance.GetServiceWorkerRegistrationsForScope(scopeUriStr, new CoreWebView2GetServiceWorkerRegistrationsCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static Task<IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>?> GetServiceWorkerRegistrationsAsync(this IComObject<ICoreWebView2ServiceWorkerManager> instance) => GetServiceWorkerRegistrationsAsync(instance?.Object!);

    public static Task<IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView>?> GetServiceWorkerRegistrationsForScopeAsync(this IComObject<ICoreWebView2ServiceWorkerManager> instance, string? scopeUri) => GetServiceWorkerRegistrationsForScopeAsync(instance?.Object!, scopeUri);
}
