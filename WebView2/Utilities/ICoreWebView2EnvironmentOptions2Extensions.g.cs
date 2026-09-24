#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptions2Extensions
{
    extension(ICoreWebView2EnvironmentOptions2 instance)
    {
        public bool ExclusiveUserDataFolderAccess
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ExclusiveUserDataFolderAccess(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ExclusiveUserDataFolderAccess(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2EnvironmentOptions2> instance)
    {
        public bool ExclusiveUserDataFolderAccess
        {
            get => (instance?.Object!).ExclusiveUserDataFolderAccess;
            set => (instance?.Object!).ExclusiveUserDataFolderAccess = value;
        }
    }
}
