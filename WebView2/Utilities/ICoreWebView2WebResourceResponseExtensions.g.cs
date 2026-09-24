#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2WebResourceResponseExtensions
{
    extension(ICoreWebView2WebResourceResponse instance)
    {
        public Stream? Content
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Content(out IStream value).ThrowOnError();
                return value != null ? new DirectN.Extensions.Utilities.StreamOnIStream(value, true) : null;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Content(value != null ? new DirectN.Extensions.Utilities.ManagedIStream(value) : null!).ThrowOnError();
            }
        }

        public IComObject<ICoreWebView2HttpResponseHeaders>? Headers
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Headers(out ICoreWebView2HttpResponseHeaders value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2HttpResponseHeaders>(value) : null;
            }
        }

        public int StatusCode
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_StatusCode(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_StatusCode(value).ThrowOnError();
            }
        }

        public string? ReasonPhrase
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ReasonPhrase(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_ReasonPhrase(valueStr).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2WebResourceResponse> instance)
    {
        public Stream? Content
        {
            get => (instance?.Object!).Content;
            set => (instance?.Object!).Content = value;
        }

        public IComObject<ICoreWebView2HttpResponseHeaders>? Headers
        {
            get => (instance?.Object!).Headers;
        }

        public int StatusCode
        {
            get => (instance?.Object!).StatusCode;
            set => (instance?.Object!).StatusCode = value;
        }

        public string? ReasonPhrase
        {
            get => (instance?.Object!).ReasonPhrase;
            set => (instance?.Object!).ReasonPhrase = value;
        }
    }
}
