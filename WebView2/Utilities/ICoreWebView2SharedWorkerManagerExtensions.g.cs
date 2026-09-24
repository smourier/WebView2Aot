#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SharedWorkerManagerExtensions
{
    public static Task<IComObject<ICoreWebView2SharedWorkerCollectionView>?> GetSharedWorkersAsync(this ICoreWebView2SharedWorkerManager instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2SharedWorkerCollectionView>?>();
        var hr = instance.GetSharedWorkers(new CoreWebView2GetSharedWorkersCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2SharedWorkerCollectionView>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static Task<IComObject<ICoreWebView2SharedWorkerCollectionView>?> GetSharedWorkersAsync(this IComObject<ICoreWebView2SharedWorkerManager> instance) => GetSharedWorkersAsync(instance?.Object!);
}
