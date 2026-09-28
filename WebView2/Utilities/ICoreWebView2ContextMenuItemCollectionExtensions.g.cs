#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ContextMenuItemCollectionExtensions
{
    public static IComObject<ICoreWebView2ContextMenuItem>? GetValueAtIndex(this ICoreWebView2ContextMenuItemCollection instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2ContextMenuItem>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2ContextMenuItem valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ContextMenuItem>(valueNative) : null;
        return value;
    }

    public static HRESULT RemoveValueAtIndex(this ICoreWebView2ContextMenuItemCollection instance, uint index, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.RemoveValueAtIndex(index).ThrowOnError(throwOnError);
    }

    public static HRESULT InsertValueAtIndex(this ICoreWebView2ContextMenuItemCollection instance, uint index, ICoreWebView2ContextMenuItem value, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.InsertValueAtIndex(index, value).ThrowOnError(throwOnError);
    }

    public static IReadOnlyList<IComObject<ICoreWebView2ContextMenuItem>> ToList(this ICoreWebView2ContextMenuItemCollection instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2ContextMenuItem>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ContextMenuItem itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ContextMenuItem>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2ContextMenuItemCollection instance, Action<IComObject<ICoreWebView2ContextMenuItem>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ContextMenuItem itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ContextMenuItem>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2ContextMenuItem>? GetValueAtIndex(this IComObject<ICoreWebView2ContextMenuItemCollection> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static HRESULT RemoveValueAtIndex(this IComObject<ICoreWebView2ContextMenuItemCollection> instance, uint index, bool throwOnError = true) => RemoveValueAtIndex(instance?.Object!, index, throwOnError);

    public static HRESULT InsertValueAtIndex(this IComObject<ICoreWebView2ContextMenuItemCollection> instance, uint index, IComObject<ICoreWebView2ContextMenuItem> value, bool throwOnError = true) => InsertValueAtIndex(instance?.Object!, index, value?.Object!, throwOnError);

    public static IReadOnlyList<IComObject<ICoreWebView2ContextMenuItem>> ToList(this IComObject<ICoreWebView2ContextMenuItemCollection> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2ContextMenuItemCollection> instance, Action<IComObject<ICoreWebView2ContextMenuItem>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2ContextMenuItemCollection instance)
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

    extension(IComObject<ICoreWebView2ContextMenuItemCollection> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
