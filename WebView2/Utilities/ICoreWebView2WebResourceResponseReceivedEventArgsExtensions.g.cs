#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2WebResourceResponseReceivedEventArgsExtensions
{
    extension(ICoreWebView2WebResourceResponseReceivedEventArgs instance)
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

        public IComObject<ICoreWebView2WebResourceResponseView>? Response
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Response(out ICoreWebView2WebResourceResponseView value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2WebResourceResponseView>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2WebResourceResponseReceivedEventArgs> instance)
    {
        public IComObject<ICoreWebView2WebResourceRequest>? Request
        {
            get => (instance?.Object!).Request;
        }

        public IComObject<ICoreWebView2WebResourceResponseView>? Response
        {
            get => (instance?.Object!).Response;
        }
    }
}
