#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ClientCertificateRequestedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2ClientCertificateRequestedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2ClientCertificateRequestedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2ClientCertificateRequestedEventArgs instance)
    {
        public string? Host
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Host(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public int Port
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_Port(ref value).ThrowOnError();
                return value;
            }
        }

        public bool IsProxy
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsProxy(ref value).ThrowOnError();
                return value;
            }
        }

        public IComObject<ICoreWebView2StringCollection>? AllowedCertificateAuthorities
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_AllowedCertificateAuthorities(out ICoreWebView2StringCollection value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2StringCollection>(value) : null;
            }
        }

        public IComObject<ICoreWebView2ClientCertificateCollection>? MutuallyTrustedCertificates
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_MutuallyTrustedCertificates(out ICoreWebView2ClientCertificateCollection value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ClientCertificateCollection>(value) : null;
            }
        }

        public IComObject<ICoreWebView2ClientCertificate>? SelectedCertificate
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_SelectedCertificate(out ICoreWebView2ClientCertificate value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ClientCertificate>(value) : null;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_SelectedCertificate(value?.Object!).ThrowOnError();
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

        public bool Handled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_Handled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Handled(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2ClientCertificateRequestedEventArgs> instance)
    {
        public string? Host
        {
            get => (instance?.Object!).Host;
        }

        public int Port
        {
            get => (instance?.Object!).Port;
        }

        public bool IsProxy
        {
            get => (instance?.Object!).IsProxy;
        }

        public IComObject<ICoreWebView2StringCollection>? AllowedCertificateAuthorities
        {
            get => (instance?.Object!).AllowedCertificateAuthorities;
        }

        public IComObject<ICoreWebView2ClientCertificateCollection>? MutuallyTrustedCertificates
        {
            get => (instance?.Object!).MutuallyTrustedCertificates;
        }

        public IComObject<ICoreWebView2ClientCertificate>? SelectedCertificate
        {
            get => (instance?.Object!).SelectedCertificate;
            set => (instance?.Object!).SelectedCertificate = value;
        }

        public bool Cancel
        {
            get => (instance?.Object!).Cancel;
            set => (instance?.Object!).Cancel = value;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }
    }
}
