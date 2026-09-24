#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2NotificationReceivedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2NotificationReceivedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2NotificationReceivedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2NotificationReceivedEventArgs instance)
    {
        public string? SenderOrigin
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_SenderOrigin(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public IComObject<ICoreWebView2Notification>? Notification
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Notification(out ICoreWebView2Notification value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2Notification>(value) : null;
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
    }

    extension(IComObject<ICoreWebView2NotificationReceivedEventArgs> instance)
    {
        public string? SenderOrigin
        {
            get => (instance?.Object!).SenderOrigin;
        }

        public IComObject<ICoreWebView2Notification>? Notification
        {
            get => (instance?.Object!).Notification;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }
    }
}
