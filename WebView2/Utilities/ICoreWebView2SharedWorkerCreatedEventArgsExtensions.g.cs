#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SharedWorkerCreatedEventArgsExtensions
{
    extension(ICoreWebView2SharedWorkerCreatedEventArgs instance)
    {
        public IComObject<ICoreWebView2SharedWorker>? Worker
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Worker(out ICoreWebView2SharedWorker value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2SharedWorker>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2SharedWorkerCreatedEventArgs> instance)
    {
        public IComObject<ICoreWebView2SharedWorker>? Worker
        {
            get => (instance?.Object!).Worker;
        }
    }
}
