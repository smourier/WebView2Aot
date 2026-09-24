#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2WebResourceResponseViewExtensions
{
    public static Task<Stream?> GetContentAsync(this ICoreWebView2WebResourceResponseView instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource<Stream?>();
        var hr = instance.GetContent(new CoreWebView2WebResourceResponseViewGetContentCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new DirectN.Extensions.Utilities.StreamOnIStream(result, true) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static Task<Stream?> GetContentAsync(this IComObject<ICoreWebView2WebResourceResponseView> instance) => GetContentAsync(instance?.Object!);

    extension(ICoreWebView2WebResourceResponseView instance)
    {
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
        }

        public string? ReasonPhrase
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ReasonPhrase(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2WebResourceResponseView> instance)
    {
        public IComObject<ICoreWebView2HttpResponseHeaders>? Headers
        {
            get => (instance?.Object!).Headers;
        }

        public int StatusCode
        {
            get => (instance?.Object!).StatusCode;
        }

        public string? ReasonPhrase
        {
            get => (instance?.Object!).ReasonPhrase;
        }
    }
}
