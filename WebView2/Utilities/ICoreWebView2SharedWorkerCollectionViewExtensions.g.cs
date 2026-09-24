#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SharedWorkerCollectionViewExtensions
{
    public static IComObject<ICoreWebView2SharedWorker>? GetValueAtIndex(this ICoreWebView2SharedWorkerCollectionView instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2SharedWorker>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2SharedWorker valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2SharedWorker>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2SharedWorker>> ToList(this ICoreWebView2SharedWorkerCollectionView instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2SharedWorker>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2SharedWorker itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2SharedWorker>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2SharedWorkerCollectionView instance, Action<IComObject<ICoreWebView2SharedWorker>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2SharedWorker itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2SharedWorker>(itemNative) : null)!;
            try
            {
                action(item);
            }
            finally
            {
                item?.Dispose();
            }
        }
    }

    public static IComObject<ICoreWebView2SharedWorker>? GetValueAtIndex(this IComObject<ICoreWebView2SharedWorkerCollectionView> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2SharedWorker>> ToList(this IComObject<ICoreWebView2SharedWorkerCollectionView> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2SharedWorkerCollectionView> instance, Action<IComObject<ICoreWebView2SharedWorker>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2SharedWorkerCollectionView instance)
    {
        public uint Count
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_Count(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2SharedWorkerCollectionView> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
