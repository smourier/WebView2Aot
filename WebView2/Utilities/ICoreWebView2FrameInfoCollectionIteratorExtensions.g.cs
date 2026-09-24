#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FrameInfoCollectionIteratorExtensions
{
    public static IComObject<ICoreWebView2FrameInfo>? GetCurrent(this ICoreWebView2FrameInfoCollectionIterator instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2FrameInfo>? value;
        instance.GetCurrent(out ICoreWebView2FrameInfo valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2FrameInfo>(valueNative) : null;
        return value;
    }

    public static bool MoveNext(this ICoreWebView2FrameInfoCollectionIterator instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        bool value;
        var valueNative = BOOL.FALSE;
        instance.MoveNext(ref valueNative).ThrowOnError();
        value = valueNative;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2FrameInfo>> ToList(this ICoreWebView2FrameInfoCollectionIterator instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2FrameInfo>>();
        while (true)
        {
            var hasCurrent = BOOL.FALSE;
            instance.get_HasCurrent(ref hasCurrent).ThrowOnError();
            if (!hasCurrent)
                break;

            instance.GetCurrent(out ICoreWebView2FrameInfo itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2FrameInfo>(itemNative) : null)!;
            list.Add(item);

            var hasNext = BOOL.FALSE;
            instance.MoveNext(ref hasNext).ThrowOnError();
            if (!hasNext)
                break;
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2FrameInfoCollectionIterator instance, Action<IComObject<ICoreWebView2FrameInfo>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        while (true)
        {
            var hasCurrent = BOOL.FALSE;
            instance.get_HasCurrent(ref hasCurrent).ThrowOnError();
            if (!hasCurrent)
                break;

            instance.GetCurrent(out ICoreWebView2FrameInfo itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2FrameInfo>(itemNative) : null)!;
            try
            {
                action(item);
            }
            finally
            {
                item?.Dispose();
            }

            var hasNext = BOOL.FALSE;
            instance.MoveNext(ref hasNext).ThrowOnError();
            if (!hasNext)
                break;
        }
    }

    public static IComObject<ICoreWebView2FrameInfo>? GetCurrent(this IComObject<ICoreWebView2FrameInfoCollectionIterator> instance) => GetCurrent(instance?.Object!);

    public static bool MoveNext(this IComObject<ICoreWebView2FrameInfoCollectionIterator> instance) => MoveNext(instance?.Object!);

    public static IReadOnlyList<IComObject<ICoreWebView2FrameInfo>> ToList(this IComObject<ICoreWebView2FrameInfoCollectionIterator> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2FrameInfoCollectionIterator> instance, Action<IComObject<ICoreWebView2FrameInfo>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2FrameInfoCollectionIterator instance)
    {
        public bool HasCurrent
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasCurrent(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2FrameInfoCollectionIterator> instance)
    {
        public bool HasCurrent
        {
            get => (instance?.Object!).HasCurrent;
        }
    }
}
