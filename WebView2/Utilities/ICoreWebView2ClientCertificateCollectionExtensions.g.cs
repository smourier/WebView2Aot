#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ClientCertificateCollectionExtensions
{
    public static IComObject<ICoreWebView2ClientCertificate>? GetValueAtIndex(this ICoreWebView2ClientCertificateCollection instance, uint index)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2ClientCertificate>? value;
        instance.GetValueAtIndex(index, out ICoreWebView2ClientCertificate valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ClientCertificate>(valueNative) : null;
        return value;
    }

    public static IReadOnlyList<IComObject<ICoreWebView2ClientCertificate>> ToList(this ICoreWebView2ClientCertificateCollection instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var list = new List<IComObject<ICoreWebView2ClientCertificate>>();
        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ClientCertificate itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ClientCertificate>(itemNative) : null)!;
            list.Add(item);
        }

        return list;
    }

    public static void ForEach(this ICoreWebView2ClientCertificateCollection instance, Action<IComObject<ICoreWebView2ClientCertificate>> action)
    {
        ArgumentNullException.ThrowIfNull(instance);
        ArgumentNullException.ThrowIfNull(action);

        uint count = default;
        instance.get_Count(ref count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            instance.GetValueAtIndex((uint)i, out ICoreWebView2ClientCertificate itemNative).ThrowOnError();
            var item = (itemNative != null ? new ComObject<ICoreWebView2ClientCertificate>(itemNative) : null)!;
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

    public static IComObject<ICoreWebView2ClientCertificate>? GetValueAtIndex(this IComObject<ICoreWebView2ClientCertificateCollection> instance, uint index) => GetValueAtIndex(instance?.Object!, index);

    public static IReadOnlyList<IComObject<ICoreWebView2ClientCertificate>> ToList(this IComObject<ICoreWebView2ClientCertificateCollection> instance) => ToList(instance?.Object!);

    public static void ForEach(this IComObject<ICoreWebView2ClientCertificateCollection> instance, Action<IComObject<ICoreWebView2ClientCertificate>> action) => ForEach(instance?.Object!, action);

    extension(ICoreWebView2ClientCertificateCollection instance)
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

    extension(IComObject<ICoreWebView2ClientCertificateCollection> instance)
    {
        public uint Count
        {
            get => (instance?.Object!).Count;
        }
    }
}
