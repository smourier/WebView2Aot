#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DownloadOperationExtensions
{
    public static void Cancel(this ICoreWebView2DownloadOperation instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Cancel().ThrowOnError();
    }

    public static void Pause(this ICoreWebView2DownloadOperation instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Pause().ThrowOnError();
    }

    public static void Resume(this ICoreWebView2DownloadOperation instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Resume().ThrowOnError();
    }

    public static void Cancel(this IComObject<ICoreWebView2DownloadOperation> instance) => Cancel(instance?.Object!);

    public static void Pause(this IComObject<ICoreWebView2DownloadOperation> instance) => Pause(instance?.Object!);

    public static void Resume(this IComObject<ICoreWebView2DownloadOperation> instance) => Resume(instance?.Object!);

    extension(ICoreWebView2DownloadOperation instance)
    {
        public string? Uri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Uri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? ContentDisposition
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ContentDisposition(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? MimeType
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_MimeType(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public long TotalBytesToReceive
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                long value = default;
                instance.get_TotalBytesToReceive(ref value).ThrowOnError();
                return value;
            }
        }

        public long BytesReceived
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                long value = default;
                instance.get_BytesReceived(ref value).ThrowOnError();
                return value;
            }
        }

        public string? EstimatedEndTime
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_EstimatedEndTime(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
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
        }

        public COREWEBVIEW2_DOWNLOAD_STATE State
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_DOWNLOAD_STATE value = default;
                instance.get_State(ref value).ThrowOnError();
                return value;
            }
        }

        public COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON InterruptReason
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON value = default;
                instance.get_InterruptReason(ref value).ThrowOnError();
                return value;
            }
        }

        public bool CanResume
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_CanResume(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2DownloadOperation> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
        }

        public string? ContentDisposition
        {
            get => (instance?.Object!).ContentDisposition;
        }

        public string? MimeType
        {
            get => (instance?.Object!).MimeType;
        }

        public long TotalBytesToReceive
        {
            get => (instance?.Object!).TotalBytesToReceive;
        }

        public long BytesReceived
        {
            get => (instance?.Object!).BytesReceived;
        }

        public string? EstimatedEndTime
        {
            get => (instance?.Object!).EstimatedEndTime;
        }

        public string? ResultFilePath
        {
            get => (instance?.Object!).ResultFilePath;
        }

        public COREWEBVIEW2_DOWNLOAD_STATE State
        {
            get => (instance?.Object!).State;
        }

        public COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON InterruptReason
        {
            get => (instance?.Object!).InterruptReason;
        }

        public bool CanResume
        {
            get => (instance?.Object!).CanResume;
        }
    }
}
