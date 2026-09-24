#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptions7Extensions
{
    extension(ICoreWebView2EnvironmentOptions7 instance)
    {
        public COREWEBVIEW2_CHANNEL_SEARCH_KIND ChannelSearchKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_CHANNEL_SEARCH_KIND value = default;
                instance.get_ChannelSearchKind(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ChannelSearchKind(value).ThrowOnError();
            }
        }

        public COREWEBVIEW2_RELEASE_CHANNELS ReleaseChannels
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_RELEASE_CHANNELS value = default;
                instance.get_ReleaseChannels(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ReleaseChannels(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2EnvironmentOptions7> instance)
    {
        public COREWEBVIEW2_CHANNEL_SEARCH_KIND ChannelSearchKind
        {
            get => (instance?.Object!).ChannelSearchKind;
            set => (instance?.Object!).ChannelSearchKind = value;
        }

        public COREWEBVIEW2_RELEASE_CHANNELS ReleaseChannels
        {
            get => (instance?.Object!).ReleaseChannels;
            set => (instance?.Object!).ReleaseChannels = value;
        }
    }
}
