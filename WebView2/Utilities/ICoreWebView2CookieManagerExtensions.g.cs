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

    public static void AddOrUpdateCookie(this ICoreWebView2CookieManager instance, ICoreWebView2Cookie cookie)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.AddOrUpdateCookie(cookie).ThrowOnError();
    }

    public static void DeleteCookie(this ICoreWebView2CookieManager instance, ICoreWebView2Cookie cookie)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.DeleteCookie(cookie).ThrowOnError();
    }

    public static void DeleteCookies(this ICoreWebView2CookieManager instance, string? name, string? uri)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        instance.DeleteCookies(nameStr, uriStr).ThrowOnError();
    }

    public static void DeleteCookiesWithDomainAndPath(this ICoreWebView2CookieManager instance, string? name, string? domain, string? path)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        using var domainStr = new DirectN.Extensions.Utilities.Pwstr(domain);
        using var pathStr = new DirectN.Extensions.Utilities.Pwstr(path);
        instance.DeleteCookiesWithDomainAndPath(nameStr, domainStr, pathStr).ThrowOnError();
    }

    public static void DeleteAllCookies(this ICoreWebView2CookieManager instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.DeleteAllCookies().ThrowOnError();
    }

    public static IComObject<ICoreWebView2Cookie>? CreateCookie(this IComObject<ICoreWebView2CookieManager> instance, string? name, string? value, string? domain, string? path) => CreateCookie(instance?.Object!, name, value, domain, path);

    public static IComObject<ICoreWebView2Cookie>? CopyCookie(this IComObject<ICoreWebView2CookieManager> instance, IComObject<ICoreWebView2Cookie> cookieParam) => CopyCookie(instance?.Object!, cookieParam?.Object!);

    public static Task<IComObject<ICoreWebView2CookieList>?> GetCookiesAsync(this IComObject<ICoreWebView2CookieManager> instance, string? uri) => GetCookiesAsync(instance?.Object!, uri);

    public static void AddOrUpdateCookie(this IComObject<ICoreWebView2CookieManager> instance, IComObject<ICoreWebView2Cookie> cookie) => AddOrUpdateCookie(instance?.Object!, cookie?.Object!);

    public static void DeleteCookie(this IComObject<ICoreWebView2CookieManager> instance, IComObject<ICoreWebView2Cookie> cookie) => DeleteCookie(instance?.Object!, cookie?.Object!);

    public static void DeleteCookies(this IComObject<ICoreWebView2CookieManager> instance, string? name, string? uri) => DeleteCookies(instance?.Object!, name, uri);

    public static void DeleteCookiesWithDomainAndPath(this IComObject<ICoreWebView2CookieManager> instance, string? name, string? domain, string? path) => DeleteCookiesWithDomainAndPath(instance?.Object!, name, domain, path);

    public static void DeleteAllCookies(this IComObject<ICoreWebView2CookieManager> instance) => DeleteAllCookies(instance?.Object!);
}
