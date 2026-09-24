#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CookieExtensions
{
    extension(ICoreWebView2Cookie instance)
    {
        public string? Name
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Name(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Value
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Value(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_Value(valueStr).ThrowOnError();
            }
        }

        public string? Domain
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Domain(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Path
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Path(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public double Expires
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_Expires(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Expires(value).ThrowOnError();
            }
        }

        public bool IsHttpOnly
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsHttpOnly(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsHttpOnly(value).ThrowOnError();
            }
        }

        public COREWEBVIEW2_COOKIE_SAME_SITE_KIND SameSite
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_COOKIE_SAME_SITE_KIND value = default;
                instance.get_SameSite(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_SameSite(value).ThrowOnError();
            }
        }

        public bool IsSecure
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsSecure(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsSecure(value).ThrowOnError();
            }
        }

        public bool IsSession
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsSession(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2Cookie> instance)
    {
        public string? Name
        {
            get => (instance?.Object!).Name;
        }

        public string? Value
        {
            get => (instance?.Object!).Value;
            set => (instance?.Object!).Value = value;
        }

        public string? Domain
        {
            get => (instance?.Object!).Domain;
        }

        public string? Path
        {
            get => (instance?.Object!).Path;
        }

        public double Expires
        {
            get => (instance?.Object!).Expires;
            set => (instance?.Object!).Expires = value;
        }

        public bool IsHttpOnly
        {
            get => (instance?.Object!).IsHttpOnly;
            set => (instance?.Object!).IsHttpOnly = value;
        }

        public COREWEBVIEW2_COOKIE_SAME_SITE_KIND SameSite
        {
            get => (instance?.Object!).SameSite;
            set => (instance?.Object!).SameSite = value;
        }

        public bool IsSecure
        {
            get => (instance?.Object!).IsSecure;
            set => (instance?.Object!).IsSecure = value;
        }

        public bool IsSession
        {
            get => (instance?.Object!).IsSession;
        }
    }
}
