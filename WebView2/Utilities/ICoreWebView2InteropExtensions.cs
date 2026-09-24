namespace WebView2.Utilities;

public static partial class ICoreWebView2InteropExtensions
{
    public static HRESULT AddHostObjectToScript(this IComObject<ICoreWebView2Interop> webView, string? name, object hostObject) => AddHostObjectToScript(webView?.Object!, name, hostObject);

    public static HRESULT AddHostObjectToScript(this ICoreWebView2Interop webView, string? name, object hostObject)
    {
        ArgumentNullException.ThrowIfNull(webView);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        return WebView2Utilities.WithHostObjectVariant(hostObject, variant => webView.AddHostObjectToScript(nameStr, ref variant.RefDetached));
    }
}
