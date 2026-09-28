#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CookieManagerExtensions
{
    public static IComObject<ICoreWebView2Cookie>? CreateCookie(this ICoreWebView2CookieManager instance, string? name, string? value, string? domain, string? path)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Cookie>? cookie;
        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
        using var domainStr = new DirectN.Extensions.Utilities.Pwstr(domain);
        using var pathStr = new DirectN.Extensions.Utilities.Pwstr(path);
        instance.CreateCookie(nameStr, valueStr, domainStr, pathStr, out ICoreWebView2Cookie cookieNative).ThrowOnError();
        cookie = cookieNative != null ? new ComObject<ICoreWebView2Cookie>(cookieNative) : null;
        return cookie;
    }

    public static IComObject<ICoreWebView2Cookie>? CopyCookie(this ICoreWebView2CookieManager instance, ICoreWebView2Cookie cookieParam)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Cookie>? cookie;
        instance.CopyCookie(cookieParam, out ICoreWebView2Cookie cookieNative).ThrowOnError();
        cookie = cookieNative != null ? new ComObject<ICoreWebView2Cookie>(cookieNative) : null;
        return cookie;
    }

    public static Task<IComObject<ICoreWebView2CookieList>?> GetCookiesAsync(this ICoreWebView2CookieManager instance, string? uri)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2CookieList>?>();
        var hr = instance.GetCookies(uriStr, new CoreWebView2GetCookiesCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2CookieList>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static HRESULT AddOrUpdateCookie(this ICoreWebView2CookieManager instance, ICoreWebView2Cookie cookie, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.AddOrUpdateCookie(cookie).ThrowOnError(throwOnError);
    }

    public static HRESULT DeleteCookie(this ICoreWebView2CookieManager instance, ICoreWebView2Cookie cookie, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.DeleteCookie(cookie).ThrowOnError(throwOnError);
    }

    public static HRESULT DeleteCookies(this ICoreWebView2CookieManager instance, string? name, string? uri, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        return instance.DeleteCookies(nameStr, uriStr).ThrowOnError(throwOnError);
    }

    public static HRESULT DeleteCookiesWithDomainAndPath(this ICoreWebView2CookieManager instance, string? name, string? domain, string? path, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        using var domainStr = new DirectN.Extensions.Utilities.Pwstr(domain);
        using var pathStr = new DirectN.Extensions.Utilities.Pwstr(path);
        return instance.DeleteCookiesWithDomainAndPath(nameStr, domainStr, pathStr).ThrowOnError(throwOnError);
    }

    public static HRESULT DeleteAllCookies(this ICoreWebView2CookieManager instance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.DeleteAllCookies().ThrowOnError(throwOnError);
    }

    public static IComObject<ICoreWebView2Cookie>? CreateCookie(this IComObject<ICoreWebView2CookieManager> instance, string? name, string? value, string? domain, string? path) => CreateCookie(instance?.Object!, name, value, domain, path);

    public static IComObject<ICoreWebView2Cookie>? CopyCookie(this IComObject<ICoreWebView2CookieManager> instance, IComObject<ICoreWebView2Cookie> cookieParam) => CopyCookie(instance?.Object!, cookieParam?.Object!);

    public static Task<IComObject<ICoreWebView2CookieList>?> GetCookiesAsync(this IComObject<ICoreWebView2CookieManager> instance, string? uri) => GetCookiesAsync(instance?.Object!, uri);

    public static HRESULT AddOrUpdateCookie(this IComObject<ICoreWebView2CookieManager> instance, IComObject<ICoreWebView2Cookie> cookie, bool throwOnError = true) => AddOrUpdateCookie(instance?.Object!, cookie?.Object!, throwOnError);

    public static HRESULT DeleteCookie(this IComObject<ICoreWebView2CookieManager> instance, IComObject<ICoreWebView2Cookie> cookie, bool throwOnError = true) => DeleteCookie(instance?.Object!, cookie?.Object!, throwOnError);

    public static HRESULT DeleteCookies(this IComObject<ICoreWebView2CookieManager> instance, string? name, string? uri, bool throwOnError = true) => DeleteCookies(instance?.Object!, name, uri, throwOnError);

    public static HRESULT DeleteCookiesWithDomainAndPath(this IComObject<ICoreWebView2CookieManager> instance, string? name, string? domain, string? path, bool throwOnError = true) => DeleteCookiesWithDomainAndPath(instance?.Object!, name, domain, path, throwOnError);

    public static HRESULT DeleteAllCookies(this IComObject<ICoreWebView2CookieManager> instance, bool throwOnError = true) => DeleteAllCookies(instance?.Object!, throwOnError);
}
