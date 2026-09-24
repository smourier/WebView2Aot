#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServiceWorkerExtensions
{
    public static void PostWebMessageAsJson(this ICoreWebView2ServiceWorker instance, string? webMessageAsJson)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var webMessageAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsJson);
        instance.PostWebMessageAsJson(webMessageAsJsonStr).ThrowOnError();
    }

    public static void PostWebMessageAsString(this ICoreWebView2ServiceWorker instance, string? webMessageAsString)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var webMessageAsStringStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsString);
        instance.PostWebMessageAsString(webMessageAsStringStr).ThrowOnError();
    }

    public static void PostWebMessageAsJson(this IComObject<ICoreWebView2ServiceWorker> instance, string? webMessageAsJson) => PostWebMessageAsJson(instance?.Object!, webMessageAsJson);

    public static void PostWebMessageAsString(this IComObject<ICoreWebView2ServiceWorker> instance, string? webMessageAsString) => PostWebMessageAsString(instance?.Object!, webMessageAsString);

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
