#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CookieListExtensions
{
    public static IComObject<ICoreWebView2Cookie>? GetValueAtIndex(this ICoreWebView2CookieList instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Cookie>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2Cookie valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2Cookie>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2Cookie>> ToList(this ICoreWebView2CookieList instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2Cookie>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2Cookie itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2Cookie>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2CookieList instance, Action<IComObject<ICoreWebView2Cookie>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2Cookie itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2Cookie>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2Cookie>? GetValueAtIndex(this IComObject<ICoreWebView2CookieList> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2Cookie>> ToList(this IComObject<ICoreWebView2CookieList> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2CookieList> instance, Action<IComObject<ICoreWebView2Cookie>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2CookieList instance)
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

    extension(IComObject<ICoreWebView2CookieList> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
