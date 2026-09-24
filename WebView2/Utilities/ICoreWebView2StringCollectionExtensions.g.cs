#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2StringCollectionExtensions
{
    public static string? GetValueAtIndex(this ICoreWebView2StringCollection instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        string? value;
        instance.GetValueAtIndex(index, out PWSTR valueNative).ThrowOnError();
        value = valueNative.ToStringAndDispose();
        return value;
    }

    public static IReadOnlyList<string?> ToList(this ICoreWebView2StringCollection instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<string?>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out PWSTR itemNative).ThrowOnError();
            var item = itemNative.ToStringAndDispose();
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2StringCollection instance, Action<string?> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out PWSTR itemNative).ThrowOnError();
            var item = itemNative.ToStringAndDispose();
            action(item);
        }
    }

    public static string? GetValueAtIndex(this IComObject<ICoreWebView2StringCollection> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<string?> ToList(this IComObject<ICoreWebView2StringCollection> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2StringCollection> instance, Action<string?> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2StringCollection instance)
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

    extension(IComObject<ICoreWebView2StringCollection> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
