#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SaveAsUIShowingEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2SaveAsUIShowingEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? value;
        instance.GetDeferral(out ICoreWebView2Deferral valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2Deferral>(valueNative) : null;
        return value;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2SaveAsUIShowingEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2SaveAsUIShowingEventArgs instance)
    {
        public string? ContentMimeType
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ContentMimeType(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool Cancel
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_Cancel(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Cancel(value).ThrowOnError();
            }
        }

        public bool SuppressDefaultDialog
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_SuppressDefaultDialog(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_SuppressDefaultDialog(value).ThrowOnError();
            }
        }

        public string? SaveAsFilePath
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_SaveAsFilePath(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_SaveAsFilePath(valueStr).ThrowOnError();
            }
        }

        public bool AllowReplace
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_AllowReplace(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_AllowReplace(value).ThrowOnError();
            }
        }

        public COREWEBVIEW2_SAVE_AS_KIND Kind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_SAVE_AS_KIND value = default;
                instance.get_Kind(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Kind(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2SaveAsUIShowingEventArgs> instance)
    {
        public string? ContentMimeType
        {
            get => (instance?.Object!).ContentMimeType;
        }

        public bool Cancel
        {
            get => (instance?.Object!).Cancel;
            set => (instance?.Object!).Cancel = value;
        }

        public bool SuppressDefaultDialog
        {
            get => (instance?.Object!).SuppressDefaultDialog;
            set => (instance?.Object!).SuppressDefaultDialog = value;
        }

        public string? SaveAsFilePath
        {
            get => (instance?.Object!).SaveAsFilePath;
            set => (instance?.Object!).SaveAsFilePath = value;
        }

        public bool AllowReplace
        {
            get => (instance?.Object!).AllowReplace;
            set => (instance?.Object!).AllowReplace = value;
        }

        public COREWEBVIEW2_SAVE_AS_KIND Kind
        {
            get => (instance?.Object!).Kind;
            set => (instance?.Object!).Kind = value;
        }
    }
}
