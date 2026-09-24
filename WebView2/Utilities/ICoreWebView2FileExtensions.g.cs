#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FileExtensions
{
    extension(ICoreWebView2File instance)
    {
        public string? Path
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Path(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2File> instance)
    {
        public string? Path
        {
            get => (instance?.Object!).Path;
        }
    }
}
