#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2BasicAuthenticationRequestedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2BasicAuthenticationRequestedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2BasicAuthenticationRequestedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2BasicAuthenticationRequestedEventArgs instance)
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

        public string? Challenge
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Challenge(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public IComObject<ICoreWebView2BasicAuthenticationResponse>? Response
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Response(out ICoreWebView2BasicAuthenticationResponse value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2BasicAuthenticationResponse>(value) : null;
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

    extension(IComObject<ICoreWebView2BasicAuthenticationRequestedEventArgs> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
        }

        public string? Challenge
        {
            get => (instance?.Object!).Challenge;
        }

        public IComObject<ICoreWebView2BasicAuthenticationResponse>? Response
        {
            get => (instance?.Object!).Response;
        }

        public bool Cancel
        {
            get => (instance?.Object!).Cancel;
            set => (instance?.Object!).Cancel = value;
        }
    }
}
