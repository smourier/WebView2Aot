#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServiceWorkerRegisteredEventArgsExtensions
{
    extension(ICoreWebView2ServiceWorkerRegisteredEventArgs instance)
    {
        public IComObject<ICoreWebView2ServiceWorkerRegistration>? ServiceWorkerRegistration
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ServiceWorkerRegistration(out ICoreWebView2ServiceWorkerRegistration value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ServiceWorkerRegistration>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2ServiceWorkerRegisteredEventArgs> instance)
    {
        public IComObject<ICoreWebView2ServiceWorkerRegistration>? ServiceWorkerRegistration
        {
            get => (instance?.Object!).ServiceWorkerRegistration;
        }
    }
}
