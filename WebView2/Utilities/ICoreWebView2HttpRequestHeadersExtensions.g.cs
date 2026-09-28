#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2HttpRequestHeadersExtensions
{
    public static string? GetHeader(this ICoreWebView2HttpRequestHeaders instance, string? name)
    {
        ArgumentNullException.ThrowIfNull(instance);

        string? value;
        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        instance.GetHeader(nameStr, out PWSTR valueNative).ThrowOnError();
        value = valueNative.ToStringAndDispose();
        return value;
    }

    public static IComObject<ICoreWebView2HttpHeadersCollectionIterator>? GetHeaders(this ICoreWebView2HttpRequestHeaders instance, string? name)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2HttpHeadersCollectionIterator>? value;
        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        instance.GetHeaders(nameStr, out ICoreWebView2HttpHeadersCollectionIterator valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2HttpHeadersCollectionIterator>(valueNative) : null;
        return value;
    }

    public static bool Contains(this ICoreWebView2HttpRequestHeaders instance, string? name)
    {
        ArgumentNullException.ThrowIfNull(instance);

        bool value;
        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        var valueNative = BOOL.FALSE;
        instance.Contains(nameStr, ref valueNative).ThrowOnError();
        value = valueNative;
        return value;
    }

    public static HRESULT SetHeader(this ICoreWebView2HttpRequestHeaders instance, string? name, string? value, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
        return instance.SetHeader(nameStr, valueStr).ThrowOnError(throwOnError);
    }

    public static HRESULT RemoveHeader(this ICoreWebView2HttpRequestHeaders instance, string? name, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        return instance.RemoveHeader(nameStr).ThrowOnError(throwOnError);
    }

    public static IComObject<ICoreWebView2HttpHeadersCollectionIterator>? GetIterator(this ICoreWebView2HttpRequestHeaders instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2HttpHeadersCollectionIterator>? value;
        instance.GetIterator(out ICoreWebView2HttpHeadersCollectionIterator valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2HttpHeadersCollectionIterator>(valueNative) : null;
        return value;
    }

    public static string? GetHeader(this IComObject<ICoreWebView2HttpRequestHeaders> instance, string? name) => GetHeader(instance?.Object!, name);

    public static IComObject<ICoreWebView2HttpHeadersCollectionIterator>? GetHeaders(this IComObject<ICoreWebView2HttpRequestHeaders> instance, string? name) => GetHeaders(instance?.Object!, name);

    public static bool Contains(this IComObject<ICoreWebView2HttpRequestHeaders> instance, string? name) => Contains(instance?.Object!, name);

    public static HRESULT SetHeader(this IComObject<ICoreWebView2HttpRequestHeaders> instance, string? name, string? value, bool throwOnError = true) => SetHeader(instance?.Object!, name, value, throwOnError);

    public static HRESULT RemoveHeader(this IComObject<ICoreWebView2HttpRequestHeaders> instance, string? name, bool throwOnError = true) => RemoveHeader(instance?.Object!, name, throwOnError);

    public static IComObject<ICoreWebView2HttpHeadersCollectionIterator>? GetIterator(this IComObject<ICoreWebView2HttpRequestHeaders> instance) => GetIterator(instance?.Object!);
}
