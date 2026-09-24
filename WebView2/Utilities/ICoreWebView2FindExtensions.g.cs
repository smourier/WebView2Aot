#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FindExtensions
{
    public static Task StartAsync(this ICoreWebView2Find instance, ICoreWebView2FindOptions options)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource();
        var hr = instance.Start(options, new CoreWebView2FindStartCompletedHandler(errorCode =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult();
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static void FindNext(this ICoreWebView2Find instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.FindNext().ThrowOnError();
    }

    public static void FindPrevious(this ICoreWebView2Find instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.FindPrevious().ThrowOnError();
    }

    public static void Stop(this ICoreWebView2Find instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Stop().ThrowOnError();
    }

    public static Task StartAsync(this IComObject<ICoreWebView2Find> instance, IComObject<ICoreWebView2FindOptions> options) => StartAsync(instance?.Object!, options?.Object!);

    public static void FindNext(this IComObject<ICoreWebView2Find> instance) => FindNext(instance?.Object!);

    public static void FindPrevious(this IComObject<ICoreWebView2Find> instance) => FindPrevious(instance?.Object!);

    public static void Stop(this IComObject<ICoreWebView2Find> instance) => Stop(instance?.Object!);

    extension(ICoreWebView2Find instance)
    {
        public int ActiveMatchIndex
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_ActiveMatchIndex(ref value).ThrowOnError();
                return value;
            }
        }

        public int MatchCount
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_MatchCount(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2Find> instance)
    {
        public int ActiveMatchIndex
        {
            get => (instance?.Object!).ActiveMatchIndex;
        }

        public int MatchCount
        {
            get => (instance?.Object!).MatchCount;
        }
    }
}
