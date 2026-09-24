#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2LaunchingExternalUriSchemeEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2LaunchingExternalUriSchemeEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? value;
        instance.GetDeferral(out ICoreWebView2Deferral valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2Deferral>(valueNative) : null;
        return value;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2LaunchingExternalUriSchemeEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2LaunchingExternalUriSchemeEventArgs instance)
    {
        public string? Uri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Uri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? InitiatingOrigin
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_InitiatingOrigin(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool IsUserInitiated
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsUserInitiated(ref value).ThrowOnError();
                return value;
            }
        }

        public bool Cancel
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_Cancel(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Cancel(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2LaunchingExternalUriSchemeEventArgs> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
        }

        public string? InitiatingOrigin
        {
            get => (instance?.Object!).InitiatingOrigin;
        }

        public bool IsUserInitiated
        {
            get => (instance?.Object!).IsUserInitiated;
        }

        public bool Cancel
        {
            get => (instance?.Object!).Cancel;
            set => (instance?.Object!).Cancel = value;
        }
    }
}
