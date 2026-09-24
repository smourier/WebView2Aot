#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DOMContentLoadedEventArgsExtensions
{
    extension(ICoreWebView2DOMContentLoadedEventArgs instance)
    {
        public ulong NavigationId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                ulong value = default;
                instance.get_NavigationId(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2DOMContentLoadedEventArgs> instance)
    {
        public ulong NavigationId
        {
            get => (instance?.Object!).NavigationId;
        }
    }
}
