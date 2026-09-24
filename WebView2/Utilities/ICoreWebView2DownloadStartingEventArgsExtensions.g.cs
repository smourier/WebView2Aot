#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DownloadStartingEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2DownloadStartingEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2DownloadStartingEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2DownloadStartingEventArgs instance)
    {
        public IComObject<ICoreWebView2DownloadOperation>? DownloadOperation
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_DownloadOperation(out ICoreWebView2DownloadOperation value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2DownloadOperation>(value) : null;
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

        public string? ResultFilePath
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ResultFilePath(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_ResultFilePath(valueStr).ThrowOnError();
            }
        }

        public bool Handled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_Handled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Handled(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2DownloadStartingEventArgs> instance)
    {
        public IComObject<ICoreWebView2DownloadOperation>? DownloadOperation
        {
            get => (instance?.Object!).DownloadOperation;
        }

        public bool Cancel
        {
            get => (instance?.Object!).Cancel;
            set => (instance?.Object!).Cancel = value;
        }

        public string? ResultFilePath
        {
            get => (instance?.Object!).ResultFilePath;
            set => (instance?.Object!).ResultFilePath = value;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }
    }
}
