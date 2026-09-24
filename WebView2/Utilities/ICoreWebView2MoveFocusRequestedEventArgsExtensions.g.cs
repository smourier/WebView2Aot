#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2MoveFocusRequestedEventArgsExtensions
{
    extension(ICoreWebView2MoveFocusRequestedEventArgs instance)
    {
        public COREWEBVIEW2_MOVE_FOCUS_REASON Reason
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_MOVE_FOCUS_REASON value = default;
                instance.get_Reason(ref value).ThrowOnError();
                return value;
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

    extension(IComObject<ICoreWebView2MoveFocusRequestedEventArgs> instance)
    {
        public COREWEBVIEW2_MOVE_FOCUS_REASON Reason
        {
            get => (instance?.Object!).Reason;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }
    }
}
