#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CustomSchemeRegistrationExtensions
{
    extension(ICoreWebView2CustomSchemeRegistration instance)
    {
        public string? SchemeName
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_SchemeName(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool TreatAsSecure
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_TreatAsSecure(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_TreatAsSecure(value).ThrowOnError();
            }
        }

        public bool HasAuthorityComponent
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasAuthorityComponent(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_HasAuthorityComponent(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2CustomSchemeRegistration> instance)
    {
        public string? SchemeName
        {
            get => (instance?.Object!).SchemeName;
        }

        public bool TreatAsSecure
        {
            get => (instance?.Object!).TreatAsSecure;
            set => (instance?.Object!).TreatAsSecure = value;
        }

        public bool HasAuthorityComponent
        {
            get => (instance?.Object!).HasAuthorityComponent;
            set => (instance?.Object!).HasAuthorityComponent = value;
        }
    }
}
