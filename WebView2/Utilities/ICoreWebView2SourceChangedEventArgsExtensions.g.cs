#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SourceChangedEventArgsExtensions
{
    extension(ICoreWebView2SourceChangedEventArgs instance)
    {
        public bool IsNewDocument
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsNewDocument(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2SourceChangedEventArgs> instance)
    {
        public bool IsNewDocument
        {
            get => (instance?.Object!).IsNewDocument;
        }
    }
}
