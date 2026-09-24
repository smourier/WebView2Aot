#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ContextMenuItemExtensions
{
    extension(ICoreWebView2ContextMenuItem instance)
    {
        public string? Name
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Name(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Label
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Label(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public int CommandId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_CommandId(ref value).ThrowOnError();
                return value;
            }
        }

        public string? ShortcutKeyDescription
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ShortcutKeyDescription(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public Stream? Icon
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Icon(out IStream value).ThrowOnError();
                return value != null ? new DirectN.Extensions.Utilities.StreamOnIStream(value, true) : null;
            }
        }

        public COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND value = default;
                instance.get_Kind(ref value).ThrowOnError();
                return value;
            }
        }

        public bool IsEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsEnabled(value).ThrowOnError();
            }
        }

        public bool IsChecked
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsChecked(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsChecked(value).ThrowOnError();
            }
        }

        public IComObject<ICoreWebView2ContextMenuItemCollection>? Children
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Children(out ICoreWebView2ContextMenuItemCollection value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ContextMenuItemCollection>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2ContextMenuItem> instance)
    {
        public string? Name
        {
            get => (instance?.Object!).Name;
        }

        public string? Label
        {
            get => (instance?.Object!).Label;
        }

        public int CommandId
        {
            get => (instance?.Object!).CommandId;
        }

        public string? ShortcutKeyDescription
        {
            get => (instance?.Object!).ShortcutKeyDescription;
        }

        public Stream? Icon
        {
            get => (instance?.Object!).Icon;
        }

        public COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind
        {
            get => (instance?.Object!).Kind;
        }

        public bool IsEnabled
        {
            get => (instance?.Object!).IsEnabled;
            set => (instance?.Object!).IsEnabled = value;
        }

        public bool IsChecked
        {
            get => (instance?.Object!).IsChecked;
            set => (instance?.Object!).IsChecked = value;
        }

        public IComObject<ICoreWebView2ContextMenuItemCollection>? Children
        {
            get => (instance?.Object!).Children;
        }
    }
}
