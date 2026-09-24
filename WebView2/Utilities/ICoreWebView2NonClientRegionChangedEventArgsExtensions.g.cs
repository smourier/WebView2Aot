#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2NonClientRegionChangedEventArgsExtensions
{
    extension(ICoreWebView2NonClientRegionChangedEventArgs instance)
    {
        public COREWEBVIEW2_NON_CLIENT_REGION_KIND RegionKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_NON_CLIENT_REGION_KIND value = default;
                instance.get_RegionKind(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2NonClientRegionChangedEventArgs> instance)
    {
        public COREWEBVIEW2_NON_CLIENT_REGION_KIND RegionKind
        {
            get => (instance?.Object!).RegionKind;
        }
    }
}
