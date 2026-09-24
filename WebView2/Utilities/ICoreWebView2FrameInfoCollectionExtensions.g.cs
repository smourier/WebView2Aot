#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FrameInfoCollectionExtensions
{
    public static IComObject<ICoreWebView2FrameInfoCollectionIterator>? GetIterator(this ICoreWebView2FrameInfoCollection instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2FrameInfoCollectionIterator>? value;
        instance.GetIterator(out ICoreWebView2FrameInfoCollectionIterator valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2FrameInfoCollectionIterator>(valueNative) : null;
        return value;
    }

    public static IComObject<ICoreWebView2FrameInfoCollectionIterator>? GetIterator(this IComObject<ICoreWebView2FrameInfoCollection> instance) => GetIterator(instance?.Object!);
}
