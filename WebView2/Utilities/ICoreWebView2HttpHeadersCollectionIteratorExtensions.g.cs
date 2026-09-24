#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2HttpHeadersCollectionIteratorExtensions
{
    public static void GetCurrentHeader(this ICoreWebView2HttpHeadersCollectionIterator instance, out string? name, out string? value)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.GetCurrentHeader(out PWSTR nameNative, out PWSTR valueNative).ThrowOnError();
        name = nameNative.ToStringAndDispose();
        value = valueNative.ToStringAndDispose();
    }

    public static bool MoveNext(this ICoreWebView2HttpHeadersCollectionIterator instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        bool hasNext;
        var hasNextNative = BOOL.FALSE;
        instance.MoveNext(ref hasNextNative).ThrowOnError();
        hasNext = hasNextNative;
        return hasNext;
    }

    public static IReadOnlyList<KeyValuePair<string?, string?>> ToList(this ICoreWebView2HttpHeadersCollectionIterator instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<KeyValuePair<string?, string?>>();
        while (true)
        {
            var hasCurrent = BOOL.FALSE;
            instance.get_HasCurrentHeader(ref hasCurrent).ThrowOnError();
            if (!hasCurrent)
                break;

            instance.GetCurrentHeader(out PWSTR item0Native, out PWSTR item1Native).ThrowOnError();
            var item = new KeyValuePair<string?, string?>(item0Native.ToStringAndDispose(), item1Native.ToStringAndDispose());
            list.Add(item);

            var hasNext = BOOL.FALSE;
            instance.MoveNext(ref hasNext).ThrowOnError();
            if (!hasNext)
                break;
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2HttpHeadersCollectionIterator instance, Action<KeyValuePair<string?, string?>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        while (true)
        {
            var hasCurrent = BOOL.FALSE;
            instance.get_HasCurrentHeader(ref hasCurrent).ThrowOnError();
            if (!hasCurrent)
                break;

            instance.GetCurrentHeader(out PWSTR item0Native, out PWSTR item1Native).ThrowOnError();
            var item = new KeyValuePair<string?, string?>(item0Native.ToStringAndDispose(), item1Native.ToStringAndDispose());
            action(item);

            var hasNext = BOOL.FALSE;
            instance.MoveNext(ref hasNext).ThrowOnError();
            if (!hasNext)
                break;
        }
    }

    public static void GetCurrentHeader(this IComObject<ICoreWebView2HttpHeadersCollectionIterator> instance, out string? name, out string? value) => GetCurrentHeader(instance?.Object!, out name, out value);

    public static bool MoveNext(this IComObject<ICoreWebView2HttpHeadersCollectionIterator> instance) => MoveNext(instance?.Object!);

    public static IReadOnlyList<KeyValuePair<string?, string?>> ToList(this IComObject<ICoreWebView2HttpHeadersCollectionIterator> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2HttpHeadersCollectionIterator> instance, Action<KeyValuePair<string?, string?>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2HttpHeadersCollectionIterator instance)
    {
        public bool HasCurrentHeader
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasCurrentHeader(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2HttpHeadersCollectionIterator> instance)
    {
        public bool HasCurrentHeader
        {
            get => (instance?.Object!).HasCurrentHeader;
        }
    }
}
