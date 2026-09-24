#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentExtensions
{
    public static Task<IComObject<ICoreWebView2Controller>?> CreateCoreWebView2ControllerAsync(this ICoreWebView2Environment instance, HWND parentWindow)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2Controller>?>();
        var hr = instance.CreateCoreWebView2Controller(parentWindow, new CoreWebView2CreateCoreWebView2ControllerCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2Controller>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static IComObject<ICoreWebView2WebResourceResponse>? CreateWebResourceResponse(this ICoreWebView2Environment instance, Stream? content, int statusCode, string? reasonPhrase, string? headers)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2WebResourceResponse>? response;
        using var reasonPhraseStr = new DirectN.Extensions.Utilities.Pwstr(reasonPhrase);
        using var headersStr = new DirectN.Extensions.Utilities.Pwstr(headers);
        instance.CreateWebResourceResponse(content != null ? new DirectN.Extensions.Utilities.ManagedIStream(content) : null, statusCode, reasonPhraseStr, headersStr, out ICoreWebView2WebResourceResponse responseNative).ThrowOnError();
        response = responseNative != null ? new ComObject<ICoreWebView2WebResourceResponse>(responseNative) : null;
        return response;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment2"/>.</remarks>
    public static IComObject<ICoreWebView2WebResourceRequest>? CreateWebResourceRequest(this ICoreWebView2Environment instance, string? uri, string? Method, Stream postData, string? Headers)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment2>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2WebResourceRequest>? value;
        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        using var MethodStr = new DirectN.Extensions.Utilities.Pwstr(Method);
        using var HeadersStr = new DirectN.Extensions.Utilities.Pwstr(Headers);
        typed.CreateWebResourceRequest(uriStr, MethodStr, new DirectN.Extensions.Utilities.ManagedIStream(postData), HeadersStr, out ICoreWebView2WebResourceRequest valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2WebResourceRequest>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment3"/>.</remarks>
    public static Task<IComObject<ICoreWebView2CompositionController>?> CreateCoreWebView2CompositionControllerAsync(this ICoreWebView2Environment instance, HWND ParentWindow)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment3>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2CompositionController>?>(default!);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2CompositionController>?>();
        var hr = typed.CreateCoreWebView2CompositionController(ParentWindow, new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2CompositionController>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment3"/>.</remarks>
    public static IComObject<ICoreWebView2PointerInfo>? CreateCoreWebView2PointerInfo(this ICoreWebView2Environment instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment3>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2PointerInfo>? value;
        typed.CreateCoreWebView2PointerInfo(out ICoreWebView2PointerInfo valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2PointerInfo>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment4"/>.</remarks>
    public static IComObject<IUnknown>? GetAutomationProviderForWindow(this ICoreWebView2Environment instance, HWND hwnd)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment4>(instance) is not { } typed)
            return default;

        IComObject<IUnknown>? value;
        typed.GetAutomationProviderForWindow(hwnd, out IUnknown valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<IUnknown>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment6"/>.</remarks>
    public static IComObject<ICoreWebView2PrintSettings>? CreatePrintSettings(this ICoreWebView2Environment instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment6>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2PrintSettings>? value;
        typed.CreatePrintSettings(out ICoreWebView2PrintSettings valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2PrintSettings>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment8"/>.</remarks>
    public static IComObject<ICoreWebView2ProcessInfoCollection>? GetProcessInfos(this ICoreWebView2Environment instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment8>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2ProcessInfoCollection>? value;
        typed.GetProcessInfos(out ICoreWebView2ProcessInfoCollection valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ProcessInfoCollection>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment9"/>.</remarks>
    public static IComObject<ICoreWebView2ContextMenuItem>? CreateContextMenuItem(this ICoreWebView2Environment instance, string? Label, Stream iconStream, COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment9>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2ContextMenuItem>? value;
        using var LabelStr = new DirectN.Extensions.Utilities.Pwstr(Label);
        typed.CreateContextMenuItem(LabelStr, new DirectN.Extensions.Utilities.ManagedIStream(iconStream), Kind, out ICoreWebView2ContextMenuItem valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ContextMenuItem>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment10"/>.</remarks>
    public static IComObject<ICoreWebView2ControllerOptions>? CreateCoreWebView2ControllerOptions(this ICoreWebView2Environment instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment10>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2ControllerOptions>? value;
        typed.CreateCoreWebView2ControllerOptions(out ICoreWebView2ControllerOptions valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2ControllerOptions>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment10"/>.</remarks>
    public static Task<IComObject<ICoreWebView2Controller>?> CreateCoreWebView2ControllerWithOptionsAsync(this ICoreWebView2Environment instance, HWND ParentWindow, ICoreWebView2ControllerOptions options)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment10>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2Controller>?>(default!);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2Controller>?>();
        var hr = typed.CreateCoreWebView2ControllerWithOptions(ParentWindow, options, new CoreWebView2CreateCoreWebView2ControllerCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2Controller>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment10"/>.</remarks>
    public static Task<IComObject<ICoreWebView2CompositionController>?> CreateCoreWebView2CompositionControllerWithOptionsAsync(this ICoreWebView2Environment instance, HWND ParentWindow, ICoreWebView2ControllerOptions options)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment10>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2CompositionController>?>(default!);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2CompositionController>?>();
        var hr = typed.CreateCoreWebView2CompositionControllerWithOptions(ParentWindow, options, new CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2CompositionController>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment12"/>.</remarks>
    public static IComObject<ICoreWebView2SharedBuffer>? CreateSharedBuffer(this ICoreWebView2Environment instance, ulong Size)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment12>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2SharedBuffer>? value;
        typed.CreateSharedBuffer(Size, out ICoreWebView2SharedBuffer valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2SharedBuffer>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment13"/>.</remarks>
    public static Task<IComObject<ICoreWebView2ProcessExtendedInfoCollection>?> GetProcessExtendedInfosAsync(this ICoreWebView2Environment instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment13>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2ProcessExtendedInfoCollection>?>(default!);

        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2ProcessExtendedInfoCollection>?>();
        var hr = typed.GetProcessExtendedInfos(new CoreWebView2GetProcessExtendedInfosCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2ProcessExtendedInfoCollection>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment14"/>.</remarks>
    public static IComObject<ICoreWebView2FileSystemHandle>? CreateWebFileSystemFileHandle(this ICoreWebView2Environment instance, string? path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment14>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2FileSystemHandle>? value;
        using var pathStr = new DirectN.Extensions.Utilities.Pwstr(path);
        typed.CreateWebFileSystemFileHandle(pathStr, permission, out ICoreWebView2FileSystemHandle valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2FileSystemHandle>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment14"/>.</remarks>
    public static IComObject<ICoreWebView2FileSystemHandle>? CreateWebFileSystemDirectoryHandle(this ICoreWebView2Environment instance, string? path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment14>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2FileSystemHandle>? value;
        using var pathStr = new DirectN.Extensions.Utilities.Pwstr(path);
        typed.CreateWebFileSystemDirectoryHandle(pathStr, permission, out ICoreWebView2FileSystemHandle valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2FileSystemHandle>(valueNative) : null;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Environment15"/>.</remarks>
    public static IComObject<ICoreWebView2FindOptions>? CreateFindOptions(this ICoreWebView2Environment instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment15>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2FindOptions>? value;
        typed.CreateFindOptions(out ICoreWebView2FindOptions valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2FindOptions>(valueNative) : null;
        return value;
    }

    public static Task<IComObject<ICoreWebView2Controller>?> CreateCoreWebView2ControllerAsync(this IComObject<ICoreWebView2Environment> instance, HWND parentWindow) => CreateCoreWebView2ControllerAsync(instance?.Object!, parentWindow);

    public static IComObject<ICoreWebView2WebResourceResponse>? CreateWebResourceResponse(this IComObject<ICoreWebView2Environment> instance, Stream? content, int statusCode, string? reasonPhrase, string? headers) => CreateWebResourceResponse(instance?.Object!, content, statusCode, reasonPhrase, headers);

    /// <remarks>Requires <see cref="ICoreWebView2Environment2"/>.</remarks>
    public static IComObject<ICoreWebView2WebResourceRequest>? CreateWebResourceRequest(this IComObject<ICoreWebView2Environment> instance, string? uri, string? Method, Stream postData, string? Headers) => CreateWebResourceRequest(instance?.Object!, uri, Method, postData, Headers);

    /// <remarks>Requires <see cref="ICoreWebView2Environment3"/>.</remarks>
    public static Task<IComObject<ICoreWebView2CompositionController>?> CreateCoreWebView2CompositionControllerAsync(this IComObject<ICoreWebView2Environment> instance, HWND ParentWindow) => CreateCoreWebView2CompositionControllerAsync(instance?.Object!, ParentWindow);

    /// <remarks>Requires <see cref="ICoreWebView2Environment3"/>.</remarks>
    public static IComObject<ICoreWebView2PointerInfo>? CreateCoreWebView2PointerInfo(this IComObject<ICoreWebView2Environment> instance) => CreateCoreWebView2PointerInfo(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Environment4"/>.</remarks>
    public static IComObject<IUnknown>? GetAutomationProviderForWindow(this IComObject<ICoreWebView2Environment> instance, HWND hwnd) => GetAutomationProviderForWindow(instance?.Object!, hwnd);

    /// <remarks>Requires <see cref="ICoreWebView2Environment6"/>.</remarks>
    public static IComObject<ICoreWebView2PrintSettings>? CreatePrintSettings(this IComObject<ICoreWebView2Environment> instance) => CreatePrintSettings(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Environment8"/>.</remarks>
    public static IComObject<ICoreWebView2ProcessInfoCollection>? GetProcessInfos(this IComObject<ICoreWebView2Environment> instance) => GetProcessInfos(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Environment9"/>.</remarks>
    public static IComObject<ICoreWebView2ContextMenuItem>? CreateContextMenuItem(this IComObject<ICoreWebView2Environment> instance, string? Label, Stream iconStream, COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind) => CreateContextMenuItem(instance?.Object!, Label, iconStream, Kind);

    /// <remarks>Requires <see cref="ICoreWebView2Environment10"/>.</remarks>
    public static IComObject<ICoreWebView2ControllerOptions>? CreateCoreWebView2ControllerOptions(this IComObject<ICoreWebView2Environment> instance) => CreateCoreWebView2ControllerOptions(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Environment10"/>.</remarks>
    public static Task<IComObject<ICoreWebView2Controller>?> CreateCoreWebView2ControllerWithOptionsAsync(this IComObject<ICoreWebView2Environment> instance, HWND ParentWindow, IComObject<ICoreWebView2ControllerOptions> options) => CreateCoreWebView2ControllerWithOptionsAsync(instance?.Object!, ParentWindow, options?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Environment10"/>.</remarks>
    public static Task<IComObject<ICoreWebView2CompositionController>?> CreateCoreWebView2CompositionControllerWithOptionsAsync(this IComObject<ICoreWebView2Environment> instance, HWND ParentWindow, IComObject<ICoreWebView2ControllerOptions> options) => CreateCoreWebView2CompositionControllerWithOptionsAsync(instance?.Object!, ParentWindow, options?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Environment12"/>.</remarks>
    public static IComObject<ICoreWebView2SharedBuffer>? CreateSharedBuffer(this IComObject<ICoreWebView2Environment> instance, ulong Size) => CreateSharedBuffer(instance?.Object!, Size);

    /// <remarks>Requires <see cref="ICoreWebView2Environment13"/>.</remarks>
    public static Task<IComObject<ICoreWebView2ProcessExtendedInfoCollection>?> GetProcessExtendedInfosAsync(this IComObject<ICoreWebView2Environment> instance) => GetProcessExtendedInfosAsync(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Environment14"/>.</remarks>
    public static IComObject<ICoreWebView2FileSystemHandle>? CreateWebFileSystemFileHandle(this IComObject<ICoreWebView2Environment> instance, string? path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission) => CreateWebFileSystemFileHandle(instance?.Object!, path, permission);

    /// <remarks>Requires <see cref="ICoreWebView2Environment14"/>.</remarks>
    public static IComObject<ICoreWebView2FileSystemHandle>? CreateWebFileSystemDirectoryHandle(this IComObject<ICoreWebView2Environment> instance, string? path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission) => CreateWebFileSystemDirectoryHandle(instance?.Object!, path, permission);

    /// <remarks>Requires <see cref="ICoreWebView2Environment15"/>.</remarks>
    public static IComObject<ICoreWebView2FindOptions>? CreateFindOptions(this IComObject<ICoreWebView2Environment> instance) => CreateFindOptions(instance?.Object!);

    extension(ICoreWebView2Environment instance)
    {
        public string? BrowserVersionString
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_BrowserVersionString(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Environment7"/>.</remarks>
        public string? UserDataFolder
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Environment7>(instance) is not { } typed)
                    return default;

                typed.get_UserDataFolder(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Environment11"/>.</remarks>
        public string? FailureReportFolderPath
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Environment11>(instance) is not { } typed)
                    return default;

                typed.get_FailureReportFolderPath(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2Environment> instance)
    {
        public string? BrowserVersionString
        {
            get => (instance?.Object!).BrowserVersionString;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Environment7"/>.</remarks>
        public string? UserDataFolder
        {
            get => (instance?.Object!).UserDataFolder;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Environment11"/>.</remarks>
        public string? FailureReportFolderPath
        {
            get => (instance?.Object!).FailureReportFolderPath;
        }
    }
}
