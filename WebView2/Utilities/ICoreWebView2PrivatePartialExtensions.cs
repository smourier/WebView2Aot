namespace WebView2.Utilities;

public static class ICoreWebView2PrivatePartialExtensions
{
    public static void AddHostObjectHelper(this IComObject<ICoreWebView2PrivatePartial> partial, ICoreWebView2PrivateHostObjectHelper helper) => AddHostObjectHelper(partial?.Object!, helper);
    public static void AddHostObjectHelper(this ICoreWebView2PrivatePartial partial, ICoreWebView2PrivateHostObjectHelper helper)
    {
        ArgumentNullException.ThrowIfNull(partial);
        ArgumentNullException.ThrowIfNull(helper);

        partial.AddHostObjectHelper(helper).ThrowOnError();
    }
}
