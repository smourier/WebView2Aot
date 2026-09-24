#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2Interop2Extensions
{
    public static IComObject<ICoreWebView2>? GetComICoreWebView2(this ICoreWebView2Interop2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2>? coreWebView2;
        instance.GetComICoreWebView2(out ICoreWebView2 coreWebView2Native).ThrowOnError();
        coreWebView2 = coreWebView2Native != null ? new ComObject<ICoreWebView2>(coreWebView2Native) : null;
        return coreWebView2;
    }

    public static IComObject<ICoreWebView2>? GetComICoreWebView2(this IComObject<ICoreWebView2Interop2> instance) => GetComICoreWebView2(instance?.Object!);
}
