#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2NewWindowRequestedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2NewWindowRequestedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2NewWindowRequestedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2NewWindowRequestedEventArgs instance)
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

        public IComObject<ICoreWebView2>? NewWindow
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_NewWindow(out ICoreWebView2 value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2>(value) : null;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_NewWindow(value?.Object!).ThrowOnError();
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

        public bool IsUserInitiated
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsUserInitiated(ref value).ThrowOnError();
                return value;
            }
        }

        public IComObject<ICoreWebView2WindowFeatures>? WindowFeatures
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_WindowFeatures(out ICoreWebView2WindowFeatures value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2WindowFeatures>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2NewWindowRequestedEventArgs2"/>.</remarks>
        public string? Name
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2NewWindowRequestedEventArgs2>(instance) is not { } typed)
                    return default;

                typed.get_Name(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2NewWindowRequestedEventArgs3"/>.</remarks>
        public IComObject<ICoreWebView2FrameInfo>? OriginalSourceFrameInfo
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2NewWindowRequestedEventArgs3>(instance) is not { } typed)
                    return default;

                typed.get_OriginalSourceFrameInfo(out ICoreWebView2FrameInfo value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2FrameInfo>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2NewWindowRequestedEventArgs> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
        }

        public IComObject<ICoreWebView2>? NewWindow
        {
            get => (instance?.Object!).NewWindow;
            set => (instance?.Object!).NewWindow = value;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }

        public bool IsUserInitiated
        {
            get => (instance?.Object!).IsUserInitiated;
        }

        public IComObject<ICoreWebView2WindowFeatures>? WindowFeatures
        {
            get => (instance?.Object!).WindowFeatures;
        }

        /// <remarks>Requires <see cref="ICoreWebView2NewWindowRequestedEventArgs2"/>.</remarks>
        public string? Name
        {
            get => (instance?.Object!).Name;
        }

        /// <remarks>Requires <see cref="ICoreWebView2NewWindowRequestedEventArgs3"/>.</remarks>
        public IComObject<ICoreWebView2FrameInfo>? OriginalSourceFrameInfo
        {
            get => (instance?.Object!).OriginalSourceFrameInfo;
        }
    }
}
