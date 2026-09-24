#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SharedWorkerExtensions
{
    extension(ICoreWebView2SharedWorker instance)
    {
        public string? Origin
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Origin(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? ScriptUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ScriptUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? TopLevelOrigin
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_TopLevelOrigin(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2SharedWorker> instance)
    {
        public string? Origin
        {
            get => (instance?.Object!).Origin;
        }

        public string? ScriptUri
        {
            get => (instance?.Object!).ScriptUri;
        }

        public string? TopLevelOrigin
        {
            get => (instance?.Object!).TopLevelOrigin;
        }
    }
}
