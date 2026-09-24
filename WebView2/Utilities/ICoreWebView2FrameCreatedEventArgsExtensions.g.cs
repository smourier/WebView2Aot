#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FrameCreatedEventArgsExtensions
{
    extension(ICoreWebView2FrameCreatedEventArgs instance)
    {
        public IComObject<ICoreWebView2Frame>? Frame
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Frame(out ICoreWebView2Frame value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2Frame>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2FrameCreatedEventArgs> instance)
    {
        public IComObject<ICoreWebView2Frame>? Frame
        {
            get => (instance?.Object!).Frame;
        }
    }
}
