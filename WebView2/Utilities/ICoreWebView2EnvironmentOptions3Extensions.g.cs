#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptions3Extensions
{
    extension(ICoreWebView2EnvironmentOptions3 instance)
    {
        public bool IsCustomCrashReportingEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsCustomCrashReportingEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsCustomCrashReportingEnabled(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2EnvironmentOptions3> instance)
    {
        public bool IsCustomCrashReportingEnabled
        {
            get => (instance?.Object!).IsCustomCrashReportingEnabled;
            set => (instance?.Object!).IsCustomCrashReportingEnabled = value;
        }
    }
}
