#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2BrowserExtensionListExtensions
{
    public static IComObject<ICoreWebView2BrowserExtension>? GetValueAtIndex(this ICoreWebView2BrowserExtensionList instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2BrowserExtension>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2BrowserExtension valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2BrowserExtension>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2BrowserExtension>> ToList(this ICoreWebView2BrowserExtensionList instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2BrowserExtension>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2BrowserExtension itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2BrowserExtension>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2BrowserExtensionList instance, Action<IComObject<ICoreWebView2BrowserExtension>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2BrowserExtension itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2BrowserExtension>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2BrowserExtension>? GetValueAtIndex(this IComObject<ICoreWebView2BrowserExtensionList> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2BrowserExtension>> ToList(this IComObject<ICoreWebView2BrowserExtensionList> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2BrowserExtensionList> instance, Action<IComObject<ICoreWebView2BrowserExtension>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2BrowserExtensionList instance)
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

    extension(IComObject<ICoreWebView2BrowserExtensionList> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
