#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptions8Extensions
{
    extension(ICoreWebView2EnvironmentOptions8 instance)
    {
        public COREWEBVIEW2_SCROLLBAR_STYLE ScrollBarStyle
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_SCROLLBAR_STYLE value = default;
                instance.get_ScrollBarStyle(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ScrollBarStyle(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2EnvironmentOptions8> instance)
    {
        public COREWEBVIEW2_SCROLLBAR_STYLE ScrollBarStyle
        {
            get => (instance?.Object!).ScrollBarStyle;
            set => (instance?.Object!).ScrollBarStyle = value;
        }
    }
}
