#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FileSystemHandleExtensions
{
    extension(ICoreWebView2FileSystemHandle instance)
    {
        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_KIND Kind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_FILE_SYSTEM_HANDLE_KIND value = default;
                instance.get_Kind(ref value).ThrowOnError();
                return value;
            }
        }

        public string? Path
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Path(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION value = default;
                instance.get_Permission(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2FileSystemHandle> instance)
    {
        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_KIND Kind
        {
            get => (instance?.Object!).Kind;
        }

        public string? Path
        {
            get => (instance?.Object!).Path;
        }

        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission
        {
            get => (instance?.Object!).Permission;
        }
    }
}
