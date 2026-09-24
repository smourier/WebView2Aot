#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2PermissionSettingCollectionViewExtensions
{
    public static IComObject<ICoreWebView2PermissionSetting>? GetValueAtIndex(this ICoreWebView2PermissionSettingCollectionView instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2PermissionSetting>? permissionSetting;
        instance.GetValueAtIndex(index, out ICoreWebView2PermissionSetting permissionSettingNative).ThrowOnError();
        permissionSetting = permissionSettingNative != null ? new ComObject<ICoreWebView2PermissionSetting>(permissionSettingNative) : null;
        return permissionSetting;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2PermissionSetting>> ToList(this ICoreWebView2PermissionSettingCollectionView instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2PermissionSetting>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2PermissionSetting itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2PermissionSetting>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2PermissionSettingCollectionView instance, Action<IComObject<ICoreWebView2PermissionSetting>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2PermissionSetting itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2PermissionSetting>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2PermissionSetting>? GetValueAtIndex(this IComObject<ICoreWebView2PermissionSettingCollectionView> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2PermissionSetting>> ToList(this IComObject<ICoreWebView2PermissionSettingCollectionView> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2PermissionSettingCollectionView> instance, Action<IComObject<ICoreWebView2PermissionSetting>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2PermissionSettingCollectionView instance)
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

    extension(IComObject<ICoreWebView2PermissionSettingCollectionView> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
