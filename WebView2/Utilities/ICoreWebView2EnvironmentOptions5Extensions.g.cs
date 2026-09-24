#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptions5Extensions
{
    extension(ICoreWebView2EnvironmentOptions5 instance)
    {
        public bool EnableTrackingPrevention
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_EnableTrackingPrevention(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_EnableTrackingPrevention(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2EnvironmentOptions5> instance)
    {
        public bool EnableTrackingPrevention
        {
            get => (instance?.Object!).EnableTrackingPrevention;
            set => (instance?.Object!).EnableTrackingPrevention = value;
        }
    }
}
