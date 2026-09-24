#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ProcessExtendedInfoCollectionExtensions
{
    public static IComObject<ICoreWebView2ProcessExtendedInfo>? GetValueAtIndex(this ICoreWebView2ProcessExtendedInfoCollection instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2ProcessExtendedInfo>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2ProcessExtendedInfo valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ProcessExtendedInfo>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2ProcessExtendedInfo>> ToList(this ICoreWebView2ProcessExtendedInfoCollection instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2ProcessExtendedInfo>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ProcessExtendedInfo itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ProcessExtendedInfo>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2ProcessExtendedInfoCollection instance, Action<IComObject<ICoreWebView2ProcessExtendedInfo>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ProcessExtendedInfo itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ProcessExtendedInfo>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2ProcessExtendedInfo>? GetValueAtIndex(this IComObject<ICoreWebView2ProcessExtendedInfoCollection> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2ProcessExtendedInfo>> ToList(this IComObject<ICoreWebView2ProcessExtendedInfoCollection> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2ProcessExtendedInfoCollection> instance, Action<IComObject<ICoreWebView2ProcessExtendedInfo>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2ProcessExtendedInfoCollection instance)
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

    extension(IComObject<ICoreWebView2ProcessExtendedInfoCollection> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
