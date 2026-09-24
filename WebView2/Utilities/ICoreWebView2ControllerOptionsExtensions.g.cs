#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ControllerOptionsExtensions
{
    extension(ICoreWebView2ControllerOptions instance)
    {
        public string? ProfileName
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ProfileName(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_ProfileName(valueStr).ThrowOnError();
            }
        }

        public bool IsInPrivateModeEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsInPrivateModeEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsInPrivateModeEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ControllerOptions2"/>.</remarks>
        public string? ScriptLocale
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ControllerOptions2>(instance) is not { } typed)
                    return default;

                typed.get_ScriptLocale(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ControllerOptions2>(instance) is not { } typed)
                    return;

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                typed.put_ScriptLocale(valueStr).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ControllerOptions3"/>.</remarks>
        public COREWEBVIEW2_COLOR DefaultBackgroundColor
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ControllerOptions3>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_COLOR value = default;
                typed.get_DefaultBackgroundColor(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ControllerOptions3>(instance) is not { } typed)
                    return;

                typed.put_DefaultBackgroundColor(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2ControllerOptions4"/>.</remarks>
        public bool AllowHostInputProcessing
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ControllerOptions4>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_AllowHostInputProcessing(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2ControllerOptions4>(instance) is not { } typed)
                    return;

                typed.put_AllowHostInputProcessing(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2ControllerOptions> instance)
    {
        public string? ProfileName
        {
            get => (instance?.Object!).ProfileName;
            set => (instance?.Object!).ProfileName = value;
        }

        public bool IsInPrivateModeEnabled
        {
            get => (instance?.Object!).IsInPrivateModeEnabled;
            set => (instance?.Object!).IsInPrivateModeEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ControllerOptions2"/>.</remarks>
        public string? ScriptLocale
        {
            get => (instance?.Object!).ScriptLocale;
            set => (instance?.Object!).ScriptLocale = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ControllerOptions3"/>.</remarks>
        public COREWEBVIEW2_COLOR DefaultBackgroundColor
        {
            get => (instance?.Object!).DefaultBackgroundColor;
            set => (instance?.Object!).DefaultBackgroundColor = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2ControllerOptions4"/>.</remarks>
        public bool AllowHostInputProcessing
        {
            get => (instance?.Object!).AllowHostInputProcessing;
            set => (instance?.Object!).AllowHostInputProcessing = value;
        }
    }
}
