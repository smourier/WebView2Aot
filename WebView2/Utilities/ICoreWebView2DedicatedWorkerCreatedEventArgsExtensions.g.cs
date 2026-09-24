#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DedicatedWorkerCreatedEventArgsExtensions
{
    extension(ICoreWebView2DedicatedWorkerCreatedEventArgs instance)
    {
        public IComObject<ICoreWebView2FrameInfo>? OriginalSourceFrameInfo
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_OriginalSourceFrameInfo(out ICoreWebView2FrameInfo value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2FrameInfo>(value) : null;
            }
        }

        public IComObject<ICoreWebView2DedicatedWorker>? Worker
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Worker(out ICoreWebView2DedicatedWorker value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2DedicatedWorker>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2DedicatedWorkerCreatedEventArgs> instance)
    {
        public IComObject<ICoreWebView2FrameInfo>? OriginalSourceFrameInfo
        {
            get => (instance?.Object!).OriginalSourceFrameInfo;
        }

        public IComObject<ICoreWebView2DedicatedWorker>? Worker
        {
            get => (instance?.Object!).Worker;
        }
    }
}
