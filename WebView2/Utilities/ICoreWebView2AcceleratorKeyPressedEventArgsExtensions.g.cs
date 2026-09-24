#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2AcceleratorKeyPressedEventArgsExtensions
{
    extension(ICoreWebView2AcceleratorKeyPressedEventArgs instance)
    {
        public COREWEBVIEW2_KEY_EVENT_KIND KeyEventKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_KEY_EVENT_KIND value = default;
                instance.get_KeyEventKind(ref value).ThrowOnError();
                return value;
            }
        }

        public uint VirtualKey
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_VirtualKey(ref value).ThrowOnError();
                return value;
            }
        }

        public int KeyEventLParam
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_KeyEventLParam(ref value).ThrowOnError();
                return value;
            }
        }

        public COREWEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PHYSICAL_KEY_STATUS value = default;
                instance.get_PhysicalKeyStatus(ref value).ThrowOnError();
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

        /// <remarks>Requires <see cref="ICoreWebView2AcceleratorKeyPressedEventArgs2"/>.</remarks>
        public bool IsBrowserAcceleratorKeyEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2AcceleratorKeyPressedEventArgs2>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsBrowserAcceleratorKeyEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2AcceleratorKeyPressedEventArgs2>(instance) is not { } typed)
                    return;

                typed.put_IsBrowserAcceleratorKeyEnabled(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2AcceleratorKeyPressedEventArgs> instance)
    {
        public COREWEBVIEW2_KEY_EVENT_KIND KeyEventKind
        {
            get => (instance?.Object!).KeyEventKind;
        }

        public uint VirtualKey
        {
            get => (instance?.Object!).VirtualKey;
        }

        public int KeyEventLParam
        {
            get => (instance?.Object!).KeyEventLParam;
        }

        public COREWEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus
        {
            get => (instance?.Object!).PhysicalKeyStatus;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2AcceleratorKeyPressedEventArgs2"/>.</remarks>
        public bool IsBrowserAcceleratorKeyEnabled
        {
            get => (instance?.Object!).IsBrowserAcceleratorKeyEnabled;
            set => (instance?.Object!).IsBrowserAcceleratorKeyEnabled = value;
        }
    }
}
