#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DeferralExtensions
{
    public static void Complete(this ICoreWebView2Deferral instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Complete().ThrowOnError();
    }

    public static void Complete(this IComObject<ICoreWebView2Deferral> instance) => Complete(instance?.Object!);
}
