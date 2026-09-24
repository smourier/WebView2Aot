#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ProcessFailedEventArgsExtensions
{
    extension(ICoreWebView2ProcessFailedEventArgs instance)
    {
        public COREWEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PROCESS_FAILED_KIND value = default;
                instance.get_ProcessFailedKind(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public COREWEBVIEW2_PROCESS_FAILED_REASON Reason
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ProcessFailedEventArgs2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_PROCESS_FAILED_REASON value = default;
                typed.get_Reason(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public int ExitCode
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ProcessFailedEventArgs2>(instance) is not { } typed)
                    return default;

                int value = default;
                typed.get_ExitCode(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public string? ProcessDescription
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ProcessFailedEventArgs2>(instance) is not { } typed)
                    return default;

                typed.get_ProcessDescription(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public IComObject<ICoreWebView2FrameInfoCollection>? FrameInfosForFailedProcess
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ProcessFailedEventArgs2>(instance) is not { } typed)
                    return default;

                typed.get_FrameInfosForFailedProcess(out ICoreWebView2FrameInfoCollection value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2FrameInfoCollection>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs3"/>.</remarks>
        public string? FailureSourceModulePath
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ProcessFailedEventArgs3>(instance) is not { } typed)
                    return default;

                typed.get_FailureSourceModulePath(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2ProcessFailedEventArgs> instance)
    {
        public COREWEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind
        {
            get => (instance?.Object!).ProcessFailedKind;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public COREWEBVIEW2_PROCESS_FAILED_REASON Reason
        {
            get => (instance?.Object!).Reason;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public int ExitCode
        {
            get => (instance?.Object!).ExitCode;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public string? ProcessDescription
        {
            get => (instance?.Object!).ProcessDescription;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs2"/>.</remarks>
        public IComObject<ICoreWebView2FrameInfoCollection>? FrameInfosForFailedProcess
        {
            get => (instance?.Object!).FrameInfosForFailedProcess;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ProcessFailedEventArgs3"/>.</remarks>
        public string? FailureSourceModulePath
        {
            get => (instance?.Object!).FailureSourceModulePath;
        }
    }
}
