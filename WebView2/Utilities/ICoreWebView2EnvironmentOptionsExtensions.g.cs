#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptionsExtensions
{
    extension(ICoreWebView2EnvironmentOptions instance)
    {
        public string? AdditionalBrowserArguments
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_AdditionalBrowserArguments(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_AdditionalBrowserArguments(valueStr).ThrowOnError();
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

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_Language(valueStr).ThrowOnError();
            }
        }

        public string? TargetCompatibleBrowserVersion
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_TargetCompatibleBrowserVersion(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_TargetCompatibleBrowserVersion(valueStr).ThrowOnError();
            }
        }

        public bool AllowSingleSignOnUsingOSPrimaryAccount
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_AllowSingleSignOnUsingOSPrimaryAccount(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_AllowSingleSignOnUsingOSPrimaryAccount(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2EnvironmentOptions> instance)
    {
        public string? AdditionalBrowserArguments
        {
            get => (instance?.Object!).AdditionalBrowserArguments;
            set => (instance?.Object!).AdditionalBrowserArguments = value;
        }

        public string? Language
        {
            get => (instance?.Object!).Language;
            set => (instance?.Object!).Language = value;
        }

        public string? TargetCompatibleBrowserVersion
        {
            get => (instance?.Object!).TargetCompatibleBrowserVersion;
            set => (instance?.Object!).TargetCompatibleBrowserVersion = value;
        }

        public bool AllowSingleSignOnUsingOSPrimaryAccount
        {
            get => (instance?.Object!).AllowSingleSignOnUsingOSPrimaryAccount;
            set => (instance?.Object!).AllowSingleSignOnUsingOSPrimaryAccount = value;
        }
    }
}
