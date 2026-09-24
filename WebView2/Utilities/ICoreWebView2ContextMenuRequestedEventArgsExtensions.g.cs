#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ContextMenuRequestedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2ContextMenuRequestedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2ContextMenuRequestedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2ContextMenuRequestedEventArgs instance)
    {
        public IComObject<ICoreWebView2ContextMenuItemCollection>? MenuItems
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_MenuItems(out ICoreWebView2ContextMenuItemCollection value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ContextMenuItemCollection>(value) : null;
            }
        }

        public IComObject<ICoreWebView2ContextMenuTarget>? ContextMenuTarget
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ContextMenuTarget(out ICoreWebView2ContextMenuTarget value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ContextMenuTarget>(value) : null;
            }
        }

        public POINT Location
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                POINT value = default;
                instance.get_Location(ref value).ThrowOnError();
                return value;
            }
        }

        public int SelectedCommandId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_SelectedCommandId(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_SelectedCommandId(value).ThrowOnError();
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

    extension(IComObject<ICoreWebView2ContextMenuRequestedEventArgs> instance)
    {
        public IComObject<ICoreWebView2ContextMenuItemCollection>? MenuItems
        {
            get => (instance?.Object!).MenuItems;
        }

        public IComObject<ICoreWebView2ContextMenuTarget>? ContextMenuTarget
        {
            get => (instance?.Object!).ContextMenuTarget;
        }

        public POINT Location
        {
            get => (instance?.Object!).Location;
        }

        public int SelectedCommandId
        {
            get => (instance?.Object!).SelectedCommandId;
            set => (instance?.Object!).SelectedCommandId = value;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }
    }
}
