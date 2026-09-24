#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ProcessInfoCollectionExtensions
{
    public static IComObject<ICoreWebView2ProcessInfo>? GetValueAtIndex(this ICoreWebView2ProcessInfoCollection instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2ProcessInfo>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2ProcessInfo valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ProcessInfo>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2ProcessInfo>> ToList(this ICoreWebView2ProcessInfoCollection instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2ProcessInfo>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ProcessInfo itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ProcessInfo>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2ProcessInfoCollection instance, Action<IComObject<ICoreWebView2ProcessInfo>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ProcessInfo itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ProcessInfo>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2ProcessInfo>? GetValueAtIndex(this IComObject<ICoreWebView2ProcessInfoCollection> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2ProcessInfo>> ToList(this IComObject<ICoreWebView2ProcessInfoCollection> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2ProcessInfoCollection> instance, Action<IComObject<ICoreWebView2ProcessInfo>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2ProcessInfoCollection instance)
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

    extension(IComObject<ICoreWebView2ProcessInfoCollection> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
