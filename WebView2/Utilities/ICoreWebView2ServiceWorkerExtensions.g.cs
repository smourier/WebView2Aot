#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServiceWorkerExtensions
{
    public static HRESULT PostWebMessageAsJson(this ICoreWebView2ServiceWorker instance, string? webMessageAsJson, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var webMessageAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsJson);
        return instance.PostWebMessageAsJson(webMessageAsJsonStr).ThrowOnError(throwOnError);
    }

    public static HRESULT PostWebMessageAsString(this ICoreWebView2ServiceWorker instance, string? webMessageAsString, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var webMessageAsStringStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsString);
        return instance.PostWebMessageAsString(webMessageAsStringStr).ThrowOnError(throwOnError);
    }

    public static HRESULT PostWebMessageAsJson(this IComObject<ICoreWebView2ServiceWorker> instance, string? webMessageAsJson, bool throwOnError = true) => PostWebMessageAsJson(instance?.Object!, webMessageAsJson, throwOnError);

    public static HRESULT PostWebMessageAsString(this IComObject<ICoreWebView2ServiceWorker> instance, string? webMessageAsString, bool throwOnError = true) => PostWebMessageAsString(instance?.Object!, webMessageAsString, throwOnError);

    extension(ICoreWebView2ServiceWorker instance)
    {
        public string? ScriptUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ScriptUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2ServiceWorker> instance)
    {
        public string? ScriptUri
        {
            get => (instance?.Object!).ScriptUri;
        }
    }
}
