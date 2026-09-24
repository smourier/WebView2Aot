#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ServerCertificateErrorDetectedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2ServerCertificateErrorDetectedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2ServerCertificateErrorDetectedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2ServerCertificateErrorDetectedEventArgs instance)
    {
        public COREWEBVIEW2_WEB_ERROR_STATUS ErrorStatus
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_WEB_ERROR_STATUS value = default;
                instance.get_ErrorStatus(ref value).ThrowOnError();
                return value;
            }
        }

        public string? RequestUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_RequestUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public IComObject<ICoreWebView2Certificate>? ServerCertificate
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ServerCertificate(out ICoreWebView2Certificate value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2Certificate>(value) : null;
            }
        }

        public COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION Action
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION value = default;
                instance.get_Action(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Action(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2ServerCertificateErrorDetectedEventArgs> instance)
    {
        public COREWEBVIEW2_WEB_ERROR_STATUS ErrorStatus
        {
            get => (instance?.Object!).ErrorStatus;
        }

        public string? RequestUri
        {
            get => (instance?.Object!).RequestUri;
        }

        public IComObject<ICoreWebView2Certificate>? ServerCertificate
        {
            get => (instance?.Object!).ServerCertificate;
        }

        public COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION Action
        {
            get => (instance?.Object!).Action;
            set => (instance?.Object!).Action = value;
        }
    }
}
