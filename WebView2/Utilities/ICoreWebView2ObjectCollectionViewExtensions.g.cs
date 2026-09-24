#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ObjectCollectionViewExtensions
{
    public static IComObject<IUnknown>? GetValueAtIndex(this ICoreWebView2ObjectCollectionView instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<IUnknown>? value;
        instance.GetValueAtIndex(index, out IUnknown valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<IUnknown>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<IUnknown>> ToList(this ICoreWebView2ObjectCollectionView instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<IUnknown>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out IUnknown itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<IUnknown>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2ObjectCollectionView instance, Action<IComObject<IUnknown>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out IUnknown itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<IUnknown>(itemNative) : null)!;
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

    /// <remarks>Requires <see cref="ICoreWebView2ObjectCollection"/>.</remarks>
    public static void RemoveValueAtIndex(this ICoreWebView2ObjectCollectionView instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2ObjectCollection>(instance) is not { } typed)
            return;

        typed.RemoveValueAtIndex(index).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2ObjectCollection"/>.</remarks>
    public static void InsertValueAtIndex(this ICoreWebView2ObjectCollectionView instance, uint index, object? value)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2ObjectCollection>(instance) is not { } typed)
            return;

        using var valueNative = DirectN.Extensions.Com.ComObject.FromPointer<IUnknown>(DirectN.Extensions.Com.ComObject.GetOrCreateComInstance(value, throwOnError: true));
        typed.InsertValueAtIndex(index, valueNative?.Object!).ThrowOnError();
    }

    public static IComObject<IUnknown>? GetValueAtIndex(this IComObject<ICoreWebView2ObjectCollectionView> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<IUnknown>> ToList(this IComObject<ICoreWebView2ObjectCollectionView> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2ObjectCollectionView> instance, Action<IComObject<IUnknown>> action) => ForEach(instance?.Object!, action);

    /// <remarks>Requires <see cref="ICoreWebView2ObjectCollection"/>.</remarks>
    public static void RemoveValueAtIndex(this IComObject<ICoreWebView2ObjectCollectionView> instance, uint index) => RemoveValueAtIndex(instance?.Object!, index);

    /// <remarks>Requires <see cref="ICoreWebView2ObjectCollection"/>.</remarks>
    public static void InsertValueAtIndex(this IComObject<ICoreWebView2ObjectCollectionView> instance, uint index, object? value) => InsertValueAtIndex(instance?.Object!, index, value);

    extension(ICoreWebView2ObjectCollectionView instance)
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

    extension(IComObject<ICoreWebView2ObjectCollectionView> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
