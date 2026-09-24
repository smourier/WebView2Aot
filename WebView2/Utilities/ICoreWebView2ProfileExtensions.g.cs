#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ProfileExtensions
{
    /// <remarks>Requires <see cref="ICoreWebView2Profile2"/>.</remarks>
    public static Task ClearBrowsingDataAsync(this ICoreWebView2Profile instance, COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile2>(instance) is not { } typed)
            return Task.CompletedTask;

        var tcs = new TaskCompletionSource();
        var hr = typed.ClearBrowsingData(dataKinds, new CoreWebView2ClearBrowsingDataCompletedHandler(errorCode =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult();
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile2"/>.</remarks>
    public static Task ClearBrowsingDataInTimeRangeAsync(this ICoreWebView2Profile instance, COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, double startTime, double endTime)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile2>(instance) is not { } typed)
            return Task.CompletedTask;

        var tcs = new TaskCompletionSource();
        var hr = typed.ClearBrowsingDataInTimeRange(dataKinds, startTime, endTime, new CoreWebView2ClearBrowsingDataCompletedHandler(errorCode =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult();
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile2"/>.</remarks>
    public static Task ClearBrowsingDataAllAsync(this ICoreWebView2Profile instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile2>(instance) is not { } typed)
            return Task.CompletedTask;

        var tcs = new TaskCompletionSource();
        var hr = typed.ClearBrowsingDataAll(new CoreWebView2ClearBrowsingDataCompletedHandler(errorCode =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult();
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile4"/>.</remarks>
    public static Task SetPermissionStateAsync(this ICoreWebView2Profile instance, COREWEBVIEW2_PERMISSION_KIND PermissionKind, string? origin, COREWEBVIEW2_PERMISSION_STATE State)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile4>(instance) is not { } typed)
            return Task.CompletedTask;

        using var originStr = new DirectN.Extensions.Utilities.Pwstr(origin);
        var tcs = new TaskCompletionSource();
        var hr = typed.SetPermissionState(PermissionKind, originStr, State, new CoreWebView2SetPermissionStateCompletedHandler(errorCode =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult();
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile4"/>.</remarks>
    public static Task<IComObject<ICoreWebView2PermissionSettingCollectionView>?> GetNonDefaultPermissionSettingsAsync(this ICoreWebView2Profile instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile4>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2PermissionSettingCollectionView>?>(default!);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2PermissionSettingCollectionView>?>();
        var hr = typed.GetNonDefaultPermissionSettings(new CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2PermissionSettingCollectionView>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile7"/>.</remarks>
    public static Task<IComObject<ICoreWebView2BrowserExtension>?> AddBrowserExtensionAsync(this ICoreWebView2Profile instance, string? extensionFolderPath)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile7>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2BrowserExtension>?>(default!);

        using var extensionFolderPathStr = new DirectN.Extensions.Utilities.Pwstr(extensionFolderPath);
        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2BrowserExtension>?>();
        var hr = typed.AddBrowserExtension(extensionFolderPathStr, new CoreWebView2ProfileAddBrowserExtensionCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2BrowserExtension>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile7"/>.</remarks>
    public static Task<IComObject<ICoreWebView2BrowserExtensionList>?> GetBrowserExtensionsAsync(this ICoreWebView2Profile instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile7>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2BrowserExtensionList>?>(default!);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2BrowserExtensionList>?>();
        var hr = typed.GetBrowserExtensions(new CoreWebView2ProfileGetBrowserExtensionsCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2BrowserExtensionList>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile8"/>.</remarks>
    public static void Delete(this ICoreWebView2Profile instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Profile8>(instance) is not { } typed)
            return;

        typed.Delete().ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2Profile2"/>.</remarks>
    public static Task ClearBrowsingDataAsync(this IComObject<ICoreWebView2Profile> instance, COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds) => ClearBrowsingDataAsync(instance?.Object!, dataKinds);

    /// <remarks>Requires <see cref="ICoreWebView2Profile2"/>.</remarks>
    public static Task ClearBrowsingDataInTimeRangeAsync(this IComObject<ICoreWebView2Profile> instance, COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, double startTime, double endTime) => ClearBrowsingDataInTimeRangeAsync(instance?.Object!, dataKinds, startTime, endTime);

    /// <remarks>Requires <see cref="ICoreWebView2Profile2"/>.</remarks>
    public static Task ClearBrowsingDataAllAsync(this IComObject<ICoreWebView2Profile> instance) => ClearBrowsingDataAllAsync(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Profile4"/>.</remarks>
    public static Task SetPermissionStateAsync(this IComObject<ICoreWebView2Profile> instance, COREWEBVIEW2_PERMISSION_KIND PermissionKind, string? origin, COREWEBVIEW2_PERMISSION_STATE State) => SetPermissionStateAsync(instance?.Object!, PermissionKind, origin, State);

    /// <remarks>Requires <see cref="ICoreWebView2Profile4"/>.</remarks>
    public static Task<IComObject<ICoreWebView2PermissionSettingCollectionView>?> GetNonDefaultPermissionSettingsAsync(this IComObject<ICoreWebView2Profile> instance) => GetNonDefaultPermissionSettingsAsync(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Profile7"/>.</remarks>
    public static Task<IComObject<ICoreWebView2BrowserExtension>?> AddBrowserExtensionAsync(this IComObject<ICoreWebView2Profile> instance, string? extensionFolderPath) => AddBrowserExtensionAsync(instance?.Object!, extensionFolderPath);

    /// <remarks>Requires <see cref="ICoreWebView2Profile7"/>.</remarks>
    public static Task<IComObject<ICoreWebView2BrowserExtensionList>?> GetBrowserExtensionsAsync(this IComObject<ICoreWebView2Profile> instance) => GetBrowserExtensionsAsync(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Profile8"/>.</remarks>
    public static void Delete(this IComObject<ICoreWebView2Profile> instance) => Delete(instance?.Object!);

    extension(ICoreWebView2Profile instance)
    {
        public string? ProfileName
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ProfileName(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
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
        }

        public string? ProfilePath
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ProfilePath(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? DefaultDownloadFolderPath
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_DefaultDownloadFolderPath(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_DefaultDownloadFolderPath(valueStr).ThrowOnError();
            }
        }

        public COREWEBVIEW2_PREFERRED_COLOR_SCHEME PreferredColorScheme
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PREFERRED_COLOR_SCHEME value = default;
                instance.get_PreferredColorScheme(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PreferredColorScheme(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile3"/>.</remarks>
        public COREWEBVIEW2_TRACKING_PREVENTION_LEVEL PreferredTrackingPreventionLevel
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile3>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_TRACKING_PREVENTION_LEVEL value = default;
                typed.get_PreferredTrackingPreventionLevel(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile3>(instance) is not { } typed)
                    return;

                typed.put_PreferredTrackingPreventionLevel(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile5"/>.</remarks>
        public IComObject<ICoreWebView2CookieManager>? CookieManager
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile5>(instance) is not { } typed)
                    return default;

                typed.get_CookieManager(out ICoreWebView2CookieManager value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2CookieManager>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile6"/>.</remarks>
        public bool IsPasswordAutosaveEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile6>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsPasswordAutosaveEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile6>(instance) is not { } typed)
                    return;

                typed.put_IsPasswordAutosaveEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile6"/>.</remarks>
        public bool IsGeneralAutofillEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile6>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsGeneralAutofillEnabled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile6>(instance) is not { } typed)
                    return;

                typed.put_IsGeneralAutofillEnabled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile9"/>.</remarks>
        public bool AreWebViewScriptApisEnabledForServiceWorkers
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile9>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_AreWebViewScriptApisEnabledForServiceWorkers(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile9>(instance) is not { } typed)
                    return;

                typed.put_AreWebViewScriptApisEnabledForServiceWorkers(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile9"/>.</remarks>
        public IComObject<ICoreWebView2ServiceWorkerManager>? ServiceWorkerManager
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile9>(instance) is not { } typed)
                    return default;

                typed.get_ServiceWorkerManager(out ICoreWebView2ServiceWorkerManager value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ServiceWorkerManager>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile9"/>.</remarks>
        public IComObject<ICoreWebView2SharedWorkerManager>? SharedWorkerManager
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Profile9>(instance) is not { } typed)
                    return default;

                typed.get_SharedWorkerManager(out ICoreWebView2SharedWorkerManager value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2SharedWorkerManager>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2Profile> instance)
    {
        public string? ProfileName
        {
            get => (instance?.Object!).ProfileName;
        }

        public bool IsInPrivateModeEnabled
        {
            get => (instance?.Object!).IsInPrivateModeEnabled;
        }

        public string? ProfilePath
        {
            get => (instance?.Object!).ProfilePath;
        }

        public string? DefaultDownloadFolderPath
        {
            get => (instance?.Object!).DefaultDownloadFolderPath;
            set => (instance?.Object!).DefaultDownloadFolderPath = value;
        }

        public COREWEBVIEW2_PREFERRED_COLOR_SCHEME PreferredColorScheme
        {
            get => (instance?.Object!).PreferredColorScheme;
            set => (instance?.Object!).PreferredColorScheme = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile3"/>.</remarks>
        public COREWEBVIEW2_TRACKING_PREVENTION_LEVEL PreferredTrackingPreventionLevel
        {
            get => (instance?.Object!).PreferredTrackingPreventionLevel;
            set => (instance?.Object!).PreferredTrackingPreventionLevel = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile5"/>.</remarks>
        public IComObject<ICoreWebView2CookieManager>? CookieManager
        {
            get => (instance?.Object!).CookieManager;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile6"/>.</remarks>
        public bool IsPasswordAutosaveEnabled
        {
            get => (instance?.Object!).IsPasswordAutosaveEnabled;
            set => (instance?.Object!).IsPasswordAutosaveEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile6"/>.</remarks>
        public bool IsGeneralAutofillEnabled
        {
            get => (instance?.Object!).IsGeneralAutofillEnabled;
            set => (instance?.Object!).IsGeneralAutofillEnabled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile9"/>.</remarks>
        public bool AreWebViewScriptApisEnabledForServiceWorkers
        {
            get => (instance?.Object!).AreWebViewScriptApisEnabledForServiceWorkers;
            set => (instance?.Object!).AreWebViewScriptApisEnabledForServiceWorkers = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile9"/>.</remarks>
        public IComObject<ICoreWebView2ServiceWorkerManager>? ServiceWorkerManager
        {
            get => (instance?.Object!).ServiceWorkerManager;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Profile9"/>.</remarks>
        public IComObject<ICoreWebView2SharedWorkerManager>? SharedWorkerManager
        {
            get => (instance?.Object!).SharedWorkerManager;
        }
    }
}
