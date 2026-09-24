#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ScreenCaptureStartingEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2ScreenCaptureStartingEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? value;
        instance.GetDeferral(out ICoreWebView2Deferral valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2Deferral>(valueNative) : null;
        return value;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2ScreenCaptureStartingEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2ScreenCaptureStartingEventArgs instance)
    {
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

        public IComObject<ICoreWebView2FrameInfo>? OriginalSourceFrameInfo
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_OriginalSourceFrameInfo(out ICoreWebView2FrameInfo value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2FrameInfo>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2ScreenCaptureStartingEventArgs> instance)
    {
        public bool Cancel
        {
            get => (instance?.Object!).Cancel;
            set => (instance?.Object!).Cancel = value;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }

        public IComObject<ICoreWebView2FrameInfo>? OriginalSourceFrameInfo
        {
            get => (instance?.Object!).OriginalSourceFrameInfo;
        }
    }
}
