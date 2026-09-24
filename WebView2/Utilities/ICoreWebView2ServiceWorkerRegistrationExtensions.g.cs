#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServiceWorkerRegistrationExtensions
{
    extension(ICoreWebView2ServiceWorkerRegistration instance)
    {
        public IComObject<ICoreWebView2ServiceWorker>? ActiveServiceWorker
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ActiveServiceWorker(out ICoreWebView2ServiceWorker value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ServiceWorker>(value) : null;
            }
        }

        public string? Origin
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Origin(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? ScopeUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ScopeUri(out PWSTR value).ThrowOnError();
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

    extension(IComObject<ICoreWebView2ServiceWorkerRegistration> instance)
    {
        public IComObject<ICoreWebView2ServiceWorker>? ActiveServiceWorker
        {
            get => (instance?.Object!).ActiveServiceWorker;
        }

        public string? Origin
        {
            get => (instance?.Object!).Origin;
        }

        public string? ScopeUri
        {
            get => (instance?.Object!).ScopeUri;
        }

        public string? TopLevelOrigin
        {
            get => (instance?.Object!).TopLevelOrigin;
        }
    }
}
