#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ContextMenuTargetExtensions
{
    extension(ICoreWebView2ContextMenuTarget instance)
    {
        public COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND Kind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND value = default;
                instance.get_Kind(ref value).ThrowOnError();
                return value;
            }
        }

        public bool IsEditable
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsEditable(ref value).ThrowOnError();
                return value;
            }
        }

        public bool IsRequestedForMainFrame
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsRequestedForMainFrame(ref value).ThrowOnError();
                return value;
            }
        }

        public string? PageUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_PageUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? FrameUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_FrameUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool HasLinkUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasLinkUri(ref value).ThrowOnError();
                return value;
            }
        }

        public string? LinkUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_LinkUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool HasLinkText
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasLinkText(ref value).ThrowOnError();
                return value;
            }
        }

        public string? LinkText
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_LinkText(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool HasSourceUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasSourceUri(ref value).ThrowOnError();
                return value;
            }
        }

        public string? SourceUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_SourceUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool HasSelection
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasSelection(ref value).ThrowOnError();
                return value;
            }
        }

        public string? SelectionText
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_SelectionText(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2ContextMenuTarget> instance)
    {
        public COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND Kind
        {
            get => (instance?.Object!).Kind;
        }

        public bool IsEditable
        {
            get => (instance?.Object!).IsEditable;
        }

        public bool IsRequestedForMainFrame
        {
            get => (instance?.Object!).IsRequestedForMainFrame;
        }

        public string? PageUri
        {
            get => (instance?.Object!).PageUri;
        }

        public string? FrameUri
        {
            get => (instance?.Object!).FrameUri;
        }

        public bool HasLinkUri
        {
            get => (instance?.Object!).HasLinkUri;
        }

        public string? LinkUri
        {
            get => (instance?.Object!).LinkUri;
        }

        public bool HasLinkText
        {
            get => (instance?.Object!).HasLinkText;
        }

        public string? LinkText
        {
            get => (instance?.Object!).LinkText;
        }

        public bool HasSourceUri
        {
            get => (instance?.Object!).HasSourceUri;
        }

        public string? SourceUri
        {
            get => (instance?.Object!).SourceUri;
        }

        public bool HasSelection
        {
            get => (instance?.Object!).HasSelection;
        }

        public string? SelectionText
        {
            get => (instance?.Object!).SelectionText;
        }
    }
}
