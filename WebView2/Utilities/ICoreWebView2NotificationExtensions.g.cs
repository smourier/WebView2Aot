#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2NotificationExtensions
{
    public static HRESULT ReportShown(this ICoreWebView2Notification instance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.ReportShown().ThrowOnError(throwOnError);
    }

    public static HRESULT ReportClicked(this ICoreWebView2Notification instance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.ReportClicked().ThrowOnError(throwOnError);
    }

    public static HRESULT ReportClosed(this ICoreWebView2Notification instance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.ReportClosed().ThrowOnError(throwOnError);
    }

    public static HRESULT ReportShown(this IComObject<ICoreWebView2Notification> instance, bool throwOnError = true) => ReportShown(instance?.Object!, throwOnError);

    public static HRESULT ReportClicked(this IComObject<ICoreWebView2Notification> instance, bool throwOnError = true) => ReportClicked(instance?.Object!, throwOnError);

    public static HRESULT ReportClosed(this IComObject<ICoreWebView2Notification> instance, bool throwOnError = true) => ReportClosed(instance?.Object!, throwOnError);

    extension(ICoreWebView2Notification instance)
    {
        public string? Body
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Body(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public COREWEBVIEW2_TEXT_DIRECTION_KIND Direction
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_TEXT_DIRECTION_KIND value = default;
                instance.get_Direction(ref value).ThrowOnError();
                return value;
            }
        }

        public string? Language
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Language(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Tag
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Tag(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? IconUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_IconUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Title
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Title(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? BadgeUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_BadgeUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? BodyImageUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_BodyImageUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool ShouldRenotify
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldRenotify(ref value).ThrowOnError();
                return value;
            }
        }

        public bool RequiresInteraction
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_RequiresInteraction(ref value).ThrowOnError();
                return value;
            }
        }

        public bool IsSilent
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsSilent(ref value).ThrowOnError();
                return value;
            }
        }

        public double Timestamp
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_Timestamp(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2Notification> instance)
    {
        public string? Body
        {
            get => (instance?.Object!).Body;
        }

        public COREWEBVIEW2_TEXT_DIRECTION_KIND Direction
        {
            get => (instance?.Object!).Direction;
        }

        public string? Language
        {
            get => (instance?.Object!).Language;
        }

        public string? Tag
        {
            get => (instance?.Object!).Tag;
        }

        public string? IconUri
        {
            get => (instance?.Object!).IconUri;
        }

        public string? Title
        {
            get => (instance?.Object!).Title;
        }

        public string? BadgeUri
        {
            get => (instance?.Object!).BadgeUri;
        }

        public string? BodyImageUri
        {
            get => (instance?.Object!).BodyImageUri;
        }

        public bool ShouldRenotify
        {
            get => (instance?.Object!).ShouldRenotify;
        }

        public bool RequiresInteraction
        {
            get => (instance?.Object!).RequiresInteraction;
        }

        public bool IsSilent
        {
            get => (instance?.Object!).IsSilent;
        }

        public double Timestamp
        {
            get => (instance?.Object!).Timestamp;
        }
    }
}
