#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ClientCertificateExtensions
{
    public static string? ToPemEncoding(this ICoreWebView2ClientCertificate instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        string? pemEncodedData;
        instance.ToPemEncoding(out PWSTR pemEncodedDataNative).ThrowOnError();
        pemEncodedData = pemEncodedDataNative.ToStringAndDispose();
        return pemEncodedData;
    }

    public static string? ToPemEncoding(this IComObject<ICoreWebView2ClientCertificate> instance) => ToPemEncoding(instance?.Object!);

    extension(ICoreWebView2ClientCertificate instance)
    {
        public string? Subject
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Subject(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Issuer
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Issuer(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public double ValidFrom
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_ValidFrom(ref value).ThrowOnError();
                return value;
            }
        }

        public double ValidTo
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_ValidTo(ref value).ThrowOnError();
                return value;
            }
        }

        public string? DerEncodedSerialNumber
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_DerEncodedSerialNumber(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? DisplayName
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_DisplayName(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public IComObject<ICoreWebView2StringCollection>? PemEncodedIssuerCertificateChain
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_PemEncodedIssuerCertificateChain(out ICoreWebView2StringCollection value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2StringCollection>(value) : null;
            }
        }

        public COREWEBVIEW2_CLIENT_CERTIFICATE_KIND Kind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_CLIENT_CERTIFICATE_KIND value = default;
                instance.get_Kind(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2ClientCertificate> instance)
    {
        public string? Subject
        {
            get => (instance?.Object!).Subject;
        }

        public string? Issuer
        {
            get => (instance?.Object!).Issuer;
        }

        public double ValidFrom
        {
            get => (instance?.Object!).ValidFrom;
        }

        public double ValidTo
        {
            get => (instance?.Object!).ValidTo;
        }

        public string? DerEncodedSerialNumber
        {
            get => (instance?.Object!).DerEncodedSerialNumber;
        }

        public string? DisplayName
        {
            get => (instance?.Object!).DisplayName;
        }

        public IComObject<ICoreWebView2StringCollection>? PemEncodedIssuerCertificateChain
        {
            get => (instance?.Object!).PemEncodedIssuerCertificateChain;
        }

        public COREWEBVIEW2_CLIENT_CERTIFICATE_KIND Kind
        {
            get => (instance?.Object!).Kind;
        }
    }
}
