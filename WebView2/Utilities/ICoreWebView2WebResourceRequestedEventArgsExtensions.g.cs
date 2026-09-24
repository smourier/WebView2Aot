#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2WebResourceRequestedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2WebResourceRequestedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2WebResourceRequestedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2WebResourceRequestedEventArgs instance)
    {
        public IComObject<ICoreWebView2WebResourceRequest>? Request
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Request(out ICoreWebView2WebResourceRequest value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2WebResourceRequest>(value) : null;
            }
        }

        public IComObject<ICoreWebView2WebResourceResponse>? Response
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Response(out ICoreWebView2WebResourceResponse value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2WebResourceResponse>(value) : null;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Response(value?.Object!).ThrowOnError();
            }
        }

        public COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_WEB_RESOURCE_CONTEXT value = default;
                instance.get_ResourceContext(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2WebResourceRequestedEventArgs2"/>.</remarks>
        public COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS RequestedSourceKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2WebResourceRequestedEventArgs2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS value = default;
                typed.get_RequestedSourceKind(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2WebResourceRequestedEventArgs> instance)
    {
        public IComObject<ICoreWebView2WebResourceRequest>? Request
        {
            get => (instance?.Object!).Request;
        }

        public IComObject<ICoreWebView2WebResourceResponse>? Response
        {
            get => (instance?.Object!).Response;
            set => (instance?.Object!).Response = value;
        }

        public COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext
        {
            get => (instance?.Object!).ResourceContext;
        }

        /// <remarks>Requires <see cref="ICoreWebView2WebResourceRequestedEventArgs2"/>.</remarks>
        public COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS RequestedSourceKind
        {
            get => (instance?.Object!).RequestedSourceKind;
        }
    }
}
