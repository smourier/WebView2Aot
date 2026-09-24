#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SaveFileSecurityCheckStartingEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2SaveFileSecurityCheckStartingEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? value;
        instance.GetDeferral(out ICoreWebView2Deferral valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2Deferral>(valueNative) : null;
        return value;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2SaveFileSecurityCheckStartingEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2SaveFileSecurityCheckStartingEventArgs instance)
    {
        public bool CancelSave
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_CancelSave(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_CancelSave(value).ThrowOnError();
            }
        }

        public string? DocumentOriginUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_DocumentOriginUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? FileExtension
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_FileExtension(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? FilePath
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_FilePath(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool SuppressDefaultPolicy
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_SuppressDefaultPolicy(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_SuppressDefaultPolicy(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2SaveFileSecurityCheckStartingEventArgs> instance)
    {
        public bool CancelSave
        {
            get => (instance?.Object!).CancelSave;
            set => (instance?.Object!).CancelSave = value;
        }

        public string? DocumentOriginUri
        {
            get => (instance?.Object!).DocumentOriginUri;
        }

        public string? FileExtension
        {
            get => (instance?.Object!).FileExtension;
        }

        public string? FilePath
        {
            get => (instance?.Object!).FilePath;
        }

        public bool SuppressDefaultPolicy
        {
            get => (instance?.Object!).SuppressDefaultPolicy;
            set => (instance?.Object!).SuppressDefaultPolicy = value;
        }
    }
}
