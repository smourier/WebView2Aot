#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2NavigationCompletedEventArgsExtensions
{
    extension(ICoreWebView2NavigationCompletedEventArgs instance)
    {
        public bool IsSuccess
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsSuccess(ref value).ThrowOnError();
                return value;
            }
        }

        public COREWEBVIEW2_WEB_ERROR_STATUS WebErrorStatus
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_WEB_ERROR_STATUS value = default;
                instance.get_WebErrorStatus(ref value).ThrowOnError();
                return value;
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

        /// <remarks>Requires <see cref="ICoreWebView2NavigationCompletedEventArgs2"/>.</remarks>
        public int HttpStatusCode
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2NavigationCompletedEventArgs2>(instance) is not { } typed)
                    return default;

                int value = default;
                typed.get_HttpStatusCode(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2NavigationCompletedEventArgs> instance)
    {
        public bool IsSuccess
        {
            get => (instance?.Object!).IsSuccess;
        }

        public COREWEBVIEW2_WEB_ERROR_STATUS WebErrorStatus
        {
            get => (instance?.Object!).WebErrorStatus;
        }

        public ulong NavigationId
        {
            get => (instance?.Object!).NavigationId;
        }

        /// <remarks>Requires <see cref="ICoreWebView2NavigationCompletedEventArgs2"/>.</remarks>
        public int HttpStatusCode
        {
            get => (instance?.Object!).HttpStatusCode;
        }
    }
}
