#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ContentLoadingEventArgsExtensions
{
    extension(ICoreWebView2ContentLoadingEventArgs instance)
    {
        public bool IsErrorPage
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsErrorPage(ref value).ThrowOnError();
                return value;
            }
        }

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

    extension(IComObject<ICoreWebView2ContentLoadingEventArgs> instance)
    {
        public bool IsErrorPage
        {
            get => (instance?.Object!).IsErrorPage;
        }

        public ulong NavigationId
        {
            get => (instance?.Object!).NavigationId;
        }
    }
}
