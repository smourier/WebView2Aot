#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2NavigationStartingEventArgsExtensions
{
    extension(ICoreWebView2NavigationStartingEventArgs instance)
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

        public bool IsRedirected
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsRedirected(ref value).ThrowOnError();
                return value;
            }
        }

        public IComObject<ICoreWebView2HttpRequestHeaders>? RequestHeaders
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_RequestHeaders(out ICoreWebView2HttpRequestHeaders value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2HttpRequestHeaders>(value) : null;
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

        public ulong NavigationId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                ulong value = default;
                instance.get_NavigationId(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2NavigationStartingEventArgs2"/>.</remarks>
        public string? AdditionalAllowedFrameAncestors
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2NavigationStartingEventArgs2>(instance) is not { } typed)
                    return default;

                typed.get_AdditionalAllowedFrameAncestors(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2NavigationStartingEventArgs2>(instance) is not { } typed)
                    return;

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                typed.put_AdditionalAllowedFrameAncestors(valueStr).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2NavigationStartingEventArgs3"/>.</remarks>
        public COREWEBVIEW2_NAVIGATION_KIND NavigationKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2NavigationStartingEventArgs3>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_NAVIGATION_KIND value = default;
                typed.get_NavigationKind(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2NavigationStartingEventArgs> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
        }

        public bool IsUserInitiated
        {
            get => (instance?.Object!).IsUserInitiated;
        }

        public bool IsRedirected
        {
            get => (instance?.Object!).IsRedirected;
        }

        public IComObject<ICoreWebView2HttpRequestHeaders>? RequestHeaders
        {
            get => (instance?.Object!).RequestHeaders;
        }

        public bool Cancel
        {
            get => (instance?.Object!).Cancel;
            set => (instance?.Object!).Cancel = value;
        }

        public ulong NavigationId
        {
            get => (instance?.Object!).NavigationId;
        }

        /// <remarks>Requires <see cref="ICoreWebView2NavigationStartingEventArgs2"/>.</remarks>
        public string? AdditionalAllowedFrameAncestors
        {
            get => (instance?.Object!).AdditionalAllowedFrameAncestors;
            set => (instance?.Object!).AdditionalAllowedFrameAncestors = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2NavigationStartingEventArgs3"/>.</remarks>
        public COREWEBVIEW2_NAVIGATION_KIND NavigationKind
        {
            get => (instance?.Object!).NavigationKind;
        }
    }
}
