#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2WebResourceRequestExtensions
{
    extension(ICoreWebView2WebResourceRequest instance)
    {
        public string? Uri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Uri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_Uri(valueStr).ThrowOnError();
            }
        }

        public string? Method
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Method(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_Method(valueStr).ThrowOnError();
            }
        }

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

        public IComObject<ICoreWebView2HttpRequestHeaders>? Headers
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Headers(out ICoreWebView2HttpRequestHeaders value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2HttpRequestHeaders>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2WebResourceRequest> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
            set => (instance?.Object!).Uri = value;
        }

        public string? Method
        {
            get => (instance?.Object!).Method;
            set => (instance?.Object!).Method = value;
        }

        public Stream? Content
        {
            get => (instance?.Object!).Content;
            set => (instance?.Object!).Content = value;
        }

        public IComObject<ICoreWebView2HttpRequestHeaders>? Headers
        {
            get => (instance?.Object!).Headers;
        }
    }
}
