#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DeferralExtensions
{
    public static HRESULT Complete(this ICoreWebView2Deferral instance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.Complete().ThrowOnError(throwOnError);
    }

    public static HRESULT Complete(this IComObject<ICoreWebView2Deferral> instance, bool throwOnError = true) => Complete(instance?.Object!, throwOnError);
}
