#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SettingsExtensions
{
    extension(ICoreWebView2Settings instance)
    {
        public bool IsScriptEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsScriptEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsScriptEnabled(value).ThrowOnError();
            }
        }

        public bool IsWebMessageEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsWebMessageEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsWebMessageEnabled(value).ThrowOnError();
            }
        }

        public bool AreDefaultScriptDialogsEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_AreDefaultScriptDialogsEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_AreDefaultScriptDialogsEnabled(value).ThrowOnError();
            }
        }

        public bool IsStatusBarEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsStatusBarEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsStatusBarEnabled(value).ThrowOnError();
            }
        }

        public bool AreDevToolsEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_AreDevToolsEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_AreDevToolsEnabled(value).ThrowOnError();
            }
        }

        public bool AreDefaultContextMenusEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_AreDefaultContextMenusEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_AreDefaultContextMenusEnabled(value).ThrowOnError();
            }
        }

        public bool AreHostObjectsAllowed
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_AreHostObjectsAllowed(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_AreHostObjectsAllowed(value).ThrowOnError();
            }
        }

        public bool IsZoomControlEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsZoomControlEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsZoomControlEnabled(value).ThrowOnError();
            }
        }

        public bool IsBuiltInErrorPageEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsBuiltInErrorPageEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsBuiltInErrorPageEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings2"/>.</remarks>
        public string? UserAgent
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings2>(instance) is not { } typed)
                    return default;

                typed.get_UserAgent(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings2>(instance) is not { } typed)
                    return;

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                typed.put_UserAgent(valueStr).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings3"/>.</remarks>
        public bool AreBrowserAcceleratorKeysEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings3>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_AreBrowserAcceleratorKeysEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings3>(instance) is not { } typed)
                    return;

                typed.put_AreBrowserAcceleratorKeysEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings4"/>.</remarks>
        public bool IsPasswordAutosaveEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings4>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsPasswordAutosaveEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings4>(instance) is not { } typed)
                    return;

                typed.put_IsPasswordAutosaveEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings4"/>.</remarks>
        public bool IsGeneralAutofillEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings4>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsGeneralAutofillEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings4>(instance) is not { } typed)
                    return;

                typed.put_IsGeneralAutofillEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings5"/>.</remarks>
        public bool IsPinchZoomEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings5>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsPinchZoomEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings5>(instance) is not { } typed)
                    return;

                typed.put_IsPinchZoomEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings6"/>.</remarks>
        public bool IsSwipeNavigationEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings6>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsSwipeNavigationEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings6>(instance) is not { } typed)
                    return;

                typed.put_IsSwipeNavigationEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings7"/>.</remarks>
        public COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings7>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_PDF_TOOLBAR_ITEMS value = default;
                typed.get_HiddenPdfToolbarItems(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings7>(instance) is not { } typed)
                    return;

                typed.put_HiddenPdfToolbarItems(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings8"/>.</remarks>
        public bool IsReputationCheckingRequired
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings8>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsReputationCheckingRequired(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings8>(instance) is not { } typed)
                    return;

                typed.put_IsReputationCheckingRequired(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings9"/>.</remarks>
        public bool IsNonClientRegionSupportEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings9>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsNonClientRegionSupportEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Settings9>(instance) is not { } typed)
                    return;

                typed.put_IsNonClientRegionSupportEnabled(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2Settings> instance)
    {
        public bool IsScriptEnabled
        {
            get => (instance?.Object!).IsScriptEnabled;
            set => (instance?.Object!).IsScriptEnabled = value;
        }

        public bool IsWebMessageEnabled
        {
            get => (instance?.Object!).IsWebMessageEnabled;
            set => (instance?.Object!).IsWebMessageEnabled = value;
        }

        public bool AreDefaultScriptDialogsEnabled
        {
            get => (instance?.Object!).AreDefaultScriptDialogsEnabled;
            set => (instance?.Object!).AreDefaultScriptDialogsEnabled = value;
        }

        public bool IsStatusBarEnabled
        {
            get => (instance?.Object!).IsStatusBarEnabled;
            set => (instance?.Object!).IsStatusBarEnabled = value;
        }

        public bool AreDevToolsEnabled
        {
            get => (instance?.Object!).AreDevToolsEnabled;
            set => (instance?.Object!).AreDevToolsEnabled = value;
        }

        public bool AreDefaultContextMenusEnabled
        {
            get => (instance?.Object!).AreDefaultContextMenusEnabled;
            set => (instance?.Object!).AreDefaultContextMenusEnabled = value;
        }

        public bool AreHostObjectsAllowed
        {
            get => (instance?.Object!).AreHostObjectsAllowed;
            set => (instance?.Object!).AreHostObjectsAllowed = value;
        }

        public bool IsZoomControlEnabled
        {
            get => (instance?.Object!).IsZoomControlEnabled;
            set => (instance?.Object!).IsZoomControlEnabled = value;
        }

        public bool IsBuiltInErrorPageEnabled
        {
            get => (instance?.Object!).IsBuiltInErrorPageEnabled;
            set => (instance?.Object!).IsBuiltInErrorPageEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings2"/>.</remarks>
        public string? UserAgent
        {
            get => (instance?.Object!).UserAgent;
            set => (instance?.Object!).UserAgent = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings3"/>.</remarks>
        public bool AreBrowserAcceleratorKeysEnabled
        {
            get => (instance?.Object!).AreBrowserAcceleratorKeysEnabled;
            set => (instance?.Object!).AreBrowserAcceleratorKeysEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings4"/>.</remarks>
        public bool IsPasswordAutosaveEnabled
        {
            get => (instance?.Object!).IsPasswordAutosaveEnabled;
            set => (instance?.Object!).IsPasswordAutosaveEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings4"/>.</remarks>
        public bool IsGeneralAutofillEnabled
        {
            get => (instance?.Object!).IsGeneralAutofillEnabled;
            set => (instance?.Object!).IsGeneralAutofillEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings5"/>.</remarks>
        public bool IsPinchZoomEnabled
        {
            get => (instance?.Object!).IsPinchZoomEnabled;
            set => (instance?.Object!).IsPinchZoomEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings6"/>.</remarks>
        public bool IsSwipeNavigationEnabled
        {
            get => (instance?.Object!).IsSwipeNavigationEnabled;
            set => (instance?.Object!).IsSwipeNavigationEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings7"/>.</remarks>
        public COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems
        {
            get => (instance?.Object!).HiddenPdfToolbarItems;
            set => (instance?.Object!).HiddenPdfToolbarItems = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings8"/>.</remarks>
        public bool IsReputationCheckingRequired
        {
            get => (instance?.Object!).IsReputationCheckingRequired;
            set => (instance?.Object!).IsReputationCheckingRequired = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Settings9"/>.</remarks>
        public bool IsNonClientRegionSupportEnabled
        {
            get => (instance?.Object!).IsNonClientRegionSupportEnabled;
            set => (instance?.Object!).IsNonClientRegionSupportEnabled = value;
        }
    }
}
