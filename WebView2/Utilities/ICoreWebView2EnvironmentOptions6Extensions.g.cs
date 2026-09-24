#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptions6Extensions
{
    extension(ICoreWebView2EnvironmentOptions6 instance)
    {
        public bool AreBrowserExtensionsEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_AreBrowserExtensionsEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_AreBrowserExtensionsEnabled(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2EnvironmentOptions6> instance)
    {
        public bool AreBrowserExtensionsEnabled
        {
            get => (instance?.Object!).AreBrowserExtensionsEnabled;
            set => (instance?.Object!).AreBrowserExtensionsEnabled = value;
        }
    }
}
