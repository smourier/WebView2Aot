#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServiceWorkerActivatedEventArgsExtensions
{
    extension(ICoreWebView2ServiceWorkerActivatedEventArgs instance)
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
    }

    extension(IComObject<ICoreWebView2ServiceWorkerActivatedEventArgs> instance)
    {
        public IComObject<ICoreWebView2ServiceWorker>? ActiveServiceWorker
        {
            get => (instance?.Object!).ActiveServiceWorker;
        }
    }
}
