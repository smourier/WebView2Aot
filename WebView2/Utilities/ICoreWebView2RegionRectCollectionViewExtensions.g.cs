#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2RegionRectCollectionViewExtensions
{
    public static RECT GetValueAtIndex(this ICoreWebView2RegionRectCollectionView instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        RECT value;
        RECT valueNative = default;
        instance.GetValueAtIndex(index, ref valueNative).ThrowOnError();
        value = valueNative;
        return value;
    }

    public static IReadOnlyList<RECT> ToList(this ICoreWebView2RegionRectCollectionView instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<RECT>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            RECT item = default;
            instance.GetValueAtIndex((uint)i, ref item).ThrowOnError();
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2RegionRectCollectionView instance, Action<RECT> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            RECT item = default;
            instance.GetValueAtIndex((uint)i, ref item).ThrowOnError();
            action(item);
        }
    }

    public static RECT GetValueAtIndex(this IComObject<ICoreWebView2RegionRectCollectionView> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<RECT> ToList(this IComObject<ICoreWebView2RegionRectCollectionView> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2RegionRectCollectionView> instance, Action<RECT> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2RegionRectCollectionView instance)
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

    extension(IComObject<ICoreWebView2RegionRectCollectionView> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
