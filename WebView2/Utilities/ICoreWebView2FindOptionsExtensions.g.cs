#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FindOptionsExtensions
{
    extension(ICoreWebView2FindOptions instance)
    {
        public string? FindTerm
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_FindTerm(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_FindTerm(valueStr).ThrowOnError();
            }
        }

        public bool IsCaseSensitive
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsCaseSensitive(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsCaseSensitive(value).ThrowOnError();
            }
        }

        public bool ShouldHighlightAllMatches
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldHighlightAllMatches(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ShouldHighlightAllMatches(value).ThrowOnError();
            }
        }

        public bool ShouldMatchWord
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldMatchWord(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ShouldMatchWord(value).ThrowOnError();
            }
        }

        public bool SuppressDefaultFindDialog
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_SuppressDefaultFindDialog(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_SuppressDefaultFindDialog(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2FindOptions> instance)
    {
        public string? FindTerm
        {
            get => (instance?.Object!).FindTerm;
            set => (instance?.Object!).FindTerm = value;
        }

        public bool IsCaseSensitive
        {
            get => (instance?.Object!).IsCaseSensitive;
            set => (instance?.Object!).IsCaseSensitive = value;
        }

        public bool ShouldHighlightAllMatches
        {
            get => (instance?.Object!).ShouldHighlightAllMatches;
            set => (instance?.Object!).ShouldHighlightAllMatches = value;
        }

        public bool ShouldMatchWord
        {
            get => (instance?.Object!).ShouldMatchWord;
            set => (instance?.Object!).ShouldMatchWord = value;
        }

        public bool SuppressDefaultFindDialog
        {
            get => (instance?.Object!).SuppressDefaultFindDialog;
            set => (instance?.Object!).SuppressDefaultFindDialog = value;
        }
    }
}
