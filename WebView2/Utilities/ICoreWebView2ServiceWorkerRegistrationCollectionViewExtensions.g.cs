#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServiceWorkerRegistrationCollectionViewExtensions
{
    public static IComObject<ICoreWebView2ServiceWorkerRegistration>? GetValueAtIndex(this ICoreWebView2ServiceWorkerRegistrationCollectionView instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2ServiceWorkerRegistration>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2ServiceWorkerRegistration valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ServiceWorkerRegistration>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2ServiceWorkerRegistration>> ToList(this ICoreWebView2ServiceWorkerRegistrationCollectionView instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2ServiceWorkerRegistration>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ServiceWorkerRegistration itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ServiceWorkerRegistration>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2ServiceWorkerRegistrationCollectionView instance, Action<IComObject<ICoreWebView2ServiceWorkerRegistration>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ServiceWorkerRegistration itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ServiceWorkerRegistration>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2ServiceWorkerRegistration>? GetValueAtIndex(this IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2ServiceWorkerRegistration>> ToList(this IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView> instance, Action<IComObject<ICoreWebView2ServiceWorkerRegistration>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2ServiceWorkerRegistrationCollectionView instance)
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

    extension(IComObject<ICoreWebView2ServiceWorkerRegistrationCollectionView> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
