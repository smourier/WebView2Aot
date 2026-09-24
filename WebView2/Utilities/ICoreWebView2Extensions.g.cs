#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2Extensions
{
    public static void Navigate(this ICoreWebView2 instance, string? uri)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        instance.Navigate(uriStr).ThrowOnError();
    }

    public static void NavigateToString(this ICoreWebView2 instance, string? htmlContent)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var htmlContentStr = new DirectN.Extensions.Utilities.Pwstr(htmlContent);
        instance.NavigateToString(htmlContentStr).ThrowOnError();
    }

    public static Task<string?> AddScriptToExecuteOnDocumentCreatedAsync(this ICoreWebView2 instance, string? javaScript)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var javaScriptStr = new DirectN.Extensions.Utilities.Pwstr(javaScript);
        var tcs = new TaskCompletionSource<string?>();
        var hr = instance.AddScriptToExecuteOnDocumentCreated(javaScriptStr, new CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result.ToString());
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static void RemoveScriptToExecuteOnDocumentCreated(this ICoreWebView2 instance, string? id)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var idStr = new DirectN.Extensions.Utilities.Pwstr(id);
        instance.RemoveScriptToExecuteOnDocumentCreated(idStr).ThrowOnError();
    }

    public static Task<string?> ExecuteScriptAsync(this ICoreWebView2 instance, string? javaScript)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var javaScriptStr = new DirectN.Extensions.Utilities.Pwstr(javaScript);
        var tcs = new TaskCompletionSource<string?>();
        var hr = instance.ExecuteScript(javaScriptStr, new CoreWebView2ExecuteScriptCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result.ToString());
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static Task CapturePreviewAsync(this ICoreWebView2 instance, COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, Stream imageStream)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource();
        var hr = instance.CapturePreview(imageFormat, new DirectN.Extensions.Utilities.ManagedIStream(imageStream), new CoreWebView2CapturePreviewCompletedHandler(errorCode =>
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

    public static void Reload(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Reload().ThrowOnError();
    }

    public static void PostWebMessageAsJson(this ICoreWebView2 instance, string? webMessageAsJson)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var webMessageAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsJson);
        instance.PostWebMessageAsJson(webMessageAsJsonStr).ThrowOnError();
    }

    public static void PostWebMessageAsString(this ICoreWebView2 instance, string? webMessageAsString)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var webMessageAsStringStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsString);
        instance.PostWebMessageAsString(webMessageAsStringStr).ThrowOnError();
    }

    public static Task<string?> CallDevToolsProtocolMethodAsync(this ICoreWebView2 instance, string? methodName, string? parametersAsJson)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var methodNameStr = new DirectN.Extensions.Utilities.Pwstr(methodName);
        using var parametersAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(parametersAsJson);
        var tcs = new TaskCompletionSource<string?>();
        var hr = instance.CallDevToolsProtocolMethod(methodNameStr, parametersAsJsonStr, new CoreWebView2CallDevToolsProtocolMethodCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result.ToString());
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static void GoBack(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.GoBack().ThrowOnError();
    }

    public static void GoForward(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.GoForward().ThrowOnError();
    }

    public static IComObject<ICoreWebView2DevToolsProtocolEventReceiver>? GetDevToolsProtocolEventReceiver(this ICoreWebView2 instance, string? eventName)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2DevToolsProtocolEventReceiver>? receiver;
        using var eventNameStr = new DirectN.Extensions.Utilities.Pwstr(eventName);
        instance.GetDevToolsProtocolEventReceiver(eventNameStr, out ICoreWebView2DevToolsProtocolEventReceiver receiverNative).ThrowOnError();
        receiver = receiverNative != null ? new ComObject<ICoreWebView2DevToolsProtocolEventReceiver>(receiverNative) : null;
        return receiver;
    }

    public static void Stop(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Stop().ThrowOnError();
    }

    public static void RemoveHostObjectFromScript(this ICoreWebView2 instance, string? name)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        instance.RemoveHostObjectFromScript(nameStr).ThrowOnError();
    }

    public static void OpenDevToolsWindow(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.OpenDevToolsWindow().ThrowOnError();
    }

    public static void AddWebResourceRequestedFilter(this ICoreWebView2 instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        instance.AddWebResourceRequestedFilter(uriStr, resourceContext).ThrowOnError();
    }

    public static void RemoveWebResourceRequestedFilter(this ICoreWebView2 instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        instance.RemoveWebResourceRequestedFilter(uriStr, resourceContext).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
    public static void NavigateWithWebResourceRequest(this ICoreWebView2 instance, ICoreWebView2WebResourceRequest request)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_2>(instance) is not { } typed)
            return;

        typed.NavigateWithWebResourceRequest(request).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static Task<bool> TrySuspendAsync(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_3>(instance) is not { } typed)
            return Task.FromResult<bool>(default!);

        var tcs = new TaskCompletionSource<bool>();
        var hr = typed.TrySuspend(new CoreWebView2TrySuspendCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static void Resume(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_3>(instance) is not { } typed)
            return;

        typed.Resume().ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static void SetVirtualHostNameToFolderMapping(this ICoreWebView2 instance, string? hostName, string? folderPath, COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_3>(instance) is not { } typed)
            return;

        using var hostNameStr = new DirectN.Extensions.Utilities.Pwstr(hostName);
        using var folderPathStr = new DirectN.Extensions.Utilities.Pwstr(folderPath);
        typed.SetVirtualHostNameToFolderMapping(hostNameStr, folderPathStr, accessKind).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static void ClearVirtualHostNameToFolderMapping(this ICoreWebView2 instance, string? hostName)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_3>(instance) is not { } typed)
            return;

        using var hostNameStr = new DirectN.Extensions.Utilities.Pwstr(hostName);
        typed.ClearVirtualHostNameToFolderMapping(hostNameStr).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_6"/>.</remarks>
    public static void OpenTaskManagerWindow(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_6>(instance) is not { } typed)
            return;

        typed.OpenTaskManagerWindow().ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_7"/>.</remarks>
    public static Task<bool> PrintToPdfAsync(this ICoreWebView2 instance, string? ResultFilePath, ICoreWebView2PrintSettings? printSettings)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_7>(instance) is not { } typed)
            return Task.FromResult<bool>(default!);

        using var ResultFilePathStr = new DirectN.Extensions.Utilities.Pwstr(ResultFilePath);
        var tcs = new TaskCompletionSource<bool>();
        var hr = typed.PrintToPdf(ResultFilePathStr, printSettings, new CoreWebView2PrintToPdfCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
    public static void OpenDefaultDownloadDialog(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_9>(instance) is not { } typed)
            return;

        typed.OpenDefaultDownloadDialog().ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
    public static void CloseDefaultDownloadDialog(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_9>(instance) is not { } typed)
            return;

        typed.CloseDefaultDownloadDialog().ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_11"/>.</remarks>
    public static Task<string?> CallDevToolsProtocolMethodForSessionAsync(this ICoreWebView2 instance, string? sessionId, string? methodName, string? parametersAsJson)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_11>(instance) is not { } typed)
            return Task.FromResult<string?>(default!);

        using var sessionIdStr = new DirectN.Extensions.Utilities.Pwstr(sessionId);
        using var methodNameStr = new DirectN.Extensions.Utilities.Pwstr(methodName);
        using var parametersAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(parametersAsJson);
        var tcs = new TaskCompletionSource<string?>();
        var hr = typed.CallDevToolsProtocolMethodForSession(sessionIdStr, methodNameStr, parametersAsJsonStr, new CoreWebView2CallDevToolsProtocolMethodCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result.ToString());
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2_14"/>.</remarks>
    public static Task ClearServerCertificateErrorActionsAsync(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_14>(instance) is not { } typed)
            return Task.CompletedTask;

        var tcs = new TaskCompletionSource();
        var hr = typed.ClearServerCertificateErrorActions(new CoreWebView2ClearServerCertificateErrorActionsCompletedHandler(errorCode =>
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

    /// <remarks>Requires <see cref="ICoreWebView2_15"/>.</remarks>
    public static Task<Stream?> GetFaviconAsync(this ICoreWebView2 instance, COREWEBVIEW2_FAVICON_IMAGE_FORMAT format)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_15>(instance) is not { } typed)
            return Task.FromResult<Stream?>(default!);

        var tcs = new TaskCompletionSource<Stream?>();
        var hr = typed.GetFavicon(format, new CoreWebView2GetFaviconCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new DirectN.Extensions.Utilities.StreamOnIStream(result, true) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2_16"/>.</remarks>
    public static Task<COREWEBVIEW2_PRINT_STATUS> PrintAsync(this ICoreWebView2 instance, ICoreWebView2PrintSettings? printSettings)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_16>(instance) is not { } typed)
            return Task.FromResult<COREWEBVIEW2_PRINT_STATUS>(default!);

        var tcs = new TaskCompletionSource<COREWEBVIEW2_PRINT_STATUS>();
        var hr = typed.Print(printSettings, new CoreWebView2PrintCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2_16"/>.</remarks>
    public static void ShowPrintUI(this ICoreWebView2 instance, COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_16>(instance) is not { } typed)
            return;

        typed.ShowPrintUI(printDialogKind).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_16"/>.</remarks>
    public static Task<Stream?> PrintToPdfStreamAsync(this ICoreWebView2 instance, ICoreWebView2PrintSettings? printSettings)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_16>(instance) is not { } typed)
            return Task.FromResult<Stream?>(default!);

        var tcs = new TaskCompletionSource<Stream?>();
        var hr = typed.PrintToPdfStream(printSettings, new CoreWebView2PrintToPdfStreamCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new DirectN.Extensions.Utilities.StreamOnIStream(result, true) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2_17"/>.</remarks>
    public static void PostSharedBufferToScript(this ICoreWebView2 instance, ICoreWebView2SharedBuffer sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, string? additionalDataAsJson)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_17>(instance) is not { } typed)
            return;

        using var additionalDataAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(additionalDataAsJson);
        typed.PostSharedBufferToScript(sharedBuffer, access, additionalDataAsJsonStr).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_21"/>.</remarks>
    public static Task<IComObject<ICoreWebView2ExecuteScriptResult>?> ExecuteScriptWithResultAsync(this ICoreWebView2 instance, string? javaScript)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_21>(instance) is not { } typed)
            return Task.FromResult<IComObject<ICoreWebView2ExecuteScriptResult>?>(default!);

        using var javaScriptStr = new DirectN.Extensions.Utilities.Pwstr(javaScript);
        var tcs = new TaskCompletionSource<IComObject<ICoreWebView2ExecuteScriptResult>?>();
        var hr = typed.ExecuteScriptWithResult(javaScriptStr, new CoreWebView2ExecuteScriptWithResultCompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result != null ? new ComObject<ICoreWebView2ExecuteScriptResult>(result) : null);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    /// <remarks>Requires <see cref="ICoreWebView2_22"/>.</remarks>
    public static void AddWebResourceRequestedFilterWithRequestSourceKinds(this ICoreWebView2 instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_22>(instance) is not { } typed)
            return;

        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        typed.AddWebResourceRequestedFilterWithRequestSourceKinds(uriStr, ResourceContext, requestSourceKinds).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_22"/>.</remarks>
    public static void RemoveWebResourceRequestedFilterWithRequestSourceKinds(this ICoreWebView2 instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_22>(instance) is not { } typed)
            return;

        using var uriStr = new DirectN.Extensions.Utilities.Pwstr(uri);
        typed.RemoveWebResourceRequestedFilterWithRequestSourceKinds(uriStr, ResourceContext, requestSourceKinds).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_23"/>.</remarks>
    public static void PostWebMessageAsJsonWithAdditionalObjects(this ICoreWebView2 instance, string? webMessageAsJson, ICoreWebView2ObjectCollectionView additionalObjects)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_23>(instance) is not { } typed)
            return;

        using var webMessageAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsJson);
        typed.PostWebMessageAsJsonWithAdditionalObjects(webMessageAsJsonStr, additionalObjects).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2_25"/>.</remarks>
    public static Task<COREWEBVIEW2_SAVE_AS_UI_RESULT> ShowSaveAsUIAsync(this ICoreWebView2 instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2_25>(instance) is not { } typed)
            return Task.FromResult<COREWEBVIEW2_SAVE_AS_UI_RESULT>(default!);

        var tcs = new TaskCompletionSource<COREWEBVIEW2_SAVE_AS_UI_RESULT>();
        var hr = typed.ShowSaveAsUI(new CoreWebView2ShowSaveAsUICompletedHandler((errorCode, result) =>
        {
            if (errorCode.IsError)
            {
                tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);
                return;
            }

            tcs.TrySetResult(result);
        }));

        if (hr.IsError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }

        return tcs.Task;
    }

    public static void Navigate(this IComObject<ICoreWebView2> instance, string? uri) => Navigate(instance?.Object!, uri);

    public static void NavigateToString(this IComObject<ICoreWebView2> instance, string? htmlContent) => NavigateToString(instance?.Object!, htmlContent);

    public static Task<string?> AddScriptToExecuteOnDocumentCreatedAsync(this IComObject<ICoreWebView2> instance, string? javaScript) => AddScriptToExecuteOnDocumentCreatedAsync(instance?.Object!, javaScript);

    public static void RemoveScriptToExecuteOnDocumentCreated(this IComObject<ICoreWebView2> instance, string? id) => RemoveScriptToExecuteOnDocumentCreated(instance?.Object!, id);

    public static Task<string?> ExecuteScriptAsync(this IComObject<ICoreWebView2> instance, string? javaScript) => ExecuteScriptAsync(instance?.Object!, javaScript);

    public static Task CapturePreviewAsync(this IComObject<ICoreWebView2> instance, COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, Stream imageStream) => CapturePreviewAsync(instance?.Object!, imageFormat, imageStream);

    public static void Reload(this IComObject<ICoreWebView2> instance) => Reload(instance?.Object!);

    public static void PostWebMessageAsJson(this IComObject<ICoreWebView2> instance, string? webMessageAsJson) => PostWebMessageAsJson(instance?.Object!, webMessageAsJson);

    public static void PostWebMessageAsString(this IComObject<ICoreWebView2> instance, string? webMessageAsString) => PostWebMessageAsString(instance?.Object!, webMessageAsString);

    public static Task<string?> CallDevToolsProtocolMethodAsync(this IComObject<ICoreWebView2> instance, string? methodName, string? parametersAsJson) => CallDevToolsProtocolMethodAsync(instance?.Object!, methodName, parametersAsJson);

    public static void GoBack(this IComObject<ICoreWebView2> instance) => GoBack(instance?.Object!);

    public static void GoForward(this IComObject<ICoreWebView2> instance) => GoForward(instance?.Object!);

    public static IComObject<ICoreWebView2DevToolsProtocolEventReceiver>? GetDevToolsProtocolEventReceiver(this IComObject<ICoreWebView2> instance, string? eventName) => GetDevToolsProtocolEventReceiver(instance?.Object!, eventName);

    public static void Stop(this IComObject<ICoreWebView2> instance) => Stop(instance?.Object!);

    public static void RemoveHostObjectFromScript(this IComObject<ICoreWebView2> instance, string? name) => RemoveHostObjectFromScript(instance?.Object!, name);

    public static void OpenDevToolsWindow(this IComObject<ICoreWebView2> instance) => OpenDevToolsWindow(instance?.Object!);

    public static void AddWebResourceRequestedFilter(this IComObject<ICoreWebView2> instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext) => AddWebResourceRequestedFilter(instance?.Object!, uri, resourceContext);

    public static void RemoveWebResourceRequestedFilter(this IComObject<ICoreWebView2> instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext) => RemoveWebResourceRequestedFilter(instance?.Object!, uri, resourceContext);

    /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
    public static void NavigateWithWebResourceRequest(this IComObject<ICoreWebView2> instance, IComObject<ICoreWebView2WebResourceRequest> request) => NavigateWithWebResourceRequest(instance?.Object!, request?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static Task<bool> TrySuspendAsync(this IComObject<ICoreWebView2> instance) => TrySuspendAsync(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static void Resume(this IComObject<ICoreWebView2> instance) => Resume(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static void SetVirtualHostNameToFolderMapping(this IComObject<ICoreWebView2> instance, string? hostName, string? folderPath, COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind) => SetVirtualHostNameToFolderMapping(instance?.Object!, hostName, folderPath, accessKind);

    /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
    public static void ClearVirtualHostNameToFolderMapping(this IComObject<ICoreWebView2> instance, string? hostName) => ClearVirtualHostNameToFolderMapping(instance?.Object!, hostName);

    /// <remarks>Requires <see cref="ICoreWebView2_6"/>.</remarks>
    public static void OpenTaskManagerWindow(this IComObject<ICoreWebView2> instance) => OpenTaskManagerWindow(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_7"/>.</remarks>
    public static Task<bool> PrintToPdfAsync(this IComObject<ICoreWebView2> instance, string? ResultFilePath, IComObject<ICoreWebView2PrintSettings>? printSettings) => PrintToPdfAsync(instance?.Object!, ResultFilePath, printSettings?.Object);

    /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
    public static void OpenDefaultDownloadDialog(this IComObject<ICoreWebView2> instance) => OpenDefaultDownloadDialog(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
    public static void CloseDefaultDownloadDialog(this IComObject<ICoreWebView2> instance) => CloseDefaultDownloadDialog(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_11"/>.</remarks>
    public static Task<string?> CallDevToolsProtocolMethodForSessionAsync(this IComObject<ICoreWebView2> instance, string? sessionId, string? methodName, string? parametersAsJson) => CallDevToolsProtocolMethodForSessionAsync(instance?.Object!, sessionId, methodName, parametersAsJson);

    /// <remarks>Requires <see cref="ICoreWebView2_14"/>.</remarks>
    public static Task ClearServerCertificateErrorActionsAsync(this IComObject<ICoreWebView2> instance) => ClearServerCertificateErrorActionsAsync(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_15"/>.</remarks>
    public static Task<Stream?> GetFaviconAsync(this IComObject<ICoreWebView2> instance, COREWEBVIEW2_FAVICON_IMAGE_FORMAT format) => GetFaviconAsync(instance?.Object!, format);

    /// <remarks>Requires <see cref="ICoreWebView2_16"/>.</remarks>
    public static Task<COREWEBVIEW2_PRINT_STATUS> PrintAsync(this IComObject<ICoreWebView2> instance, IComObject<ICoreWebView2PrintSettings>? printSettings) => PrintAsync(instance?.Object!, printSettings?.Object);

    /// <remarks>Requires <see cref="ICoreWebView2_16"/>.</remarks>
    public static void ShowPrintUI(this IComObject<ICoreWebView2> instance, COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind) => ShowPrintUI(instance?.Object!, printDialogKind);

    /// <remarks>Requires <see cref="ICoreWebView2_16"/>.</remarks>
    public static Task<Stream?> PrintToPdfStreamAsync(this IComObject<ICoreWebView2> instance, IComObject<ICoreWebView2PrintSettings>? printSettings) => PrintToPdfStreamAsync(instance?.Object!, printSettings?.Object);

    /// <remarks>Requires <see cref="ICoreWebView2_17"/>.</remarks>
    public static void PostSharedBufferToScript(this IComObject<ICoreWebView2> instance, IComObject<ICoreWebView2SharedBuffer> sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, string? additionalDataAsJson) => PostSharedBufferToScript(instance?.Object!, sharedBuffer?.Object!, access, additionalDataAsJson);

    /// <remarks>Requires <see cref="ICoreWebView2_21"/>.</remarks>
    public static Task<IComObject<ICoreWebView2ExecuteScriptResult>?> ExecuteScriptWithResultAsync(this IComObject<ICoreWebView2> instance, string? javaScript) => ExecuteScriptWithResultAsync(instance?.Object!, javaScript);

    /// <remarks>Requires <see cref="ICoreWebView2_22"/>.</remarks>
    public static void AddWebResourceRequestedFilterWithRequestSourceKinds(this IComObject<ICoreWebView2> instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds) => AddWebResourceRequestedFilterWithRequestSourceKinds(instance?.Object!, uri, ResourceContext, requestSourceKinds);

    /// <remarks>Requires <see cref="ICoreWebView2_22"/>.</remarks>
    public static void RemoveWebResourceRequestedFilterWithRequestSourceKinds(this IComObject<ICoreWebView2> instance, string? uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds) => RemoveWebResourceRequestedFilterWithRequestSourceKinds(instance?.Object!, uri, ResourceContext, requestSourceKinds);

    /// <remarks>Requires <see cref="ICoreWebView2_23"/>.</remarks>
    public static void PostWebMessageAsJsonWithAdditionalObjects(this IComObject<ICoreWebView2> instance, string? webMessageAsJson, IComObject<ICoreWebView2ObjectCollectionView> additionalObjects) => PostWebMessageAsJsonWithAdditionalObjects(instance?.Object!, webMessageAsJson, additionalObjects?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2_25"/>.</remarks>
    public static Task<COREWEBVIEW2_SAVE_AS_UI_RESULT> ShowSaveAsUIAsync(this IComObject<ICoreWebView2> instance) => ShowSaveAsUIAsync(instance?.Object!);

    extension(ICoreWebView2 instance)
    {
        public IComObject<ICoreWebView2Settings>? Settings
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Settings(out ICoreWebView2Settings value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2Settings>(value) : null;
            }
        }

        public string? Source
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Source(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public uint BrowserProcessId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_BrowserProcessId(ref value).ThrowOnError();
                return value;
            }
        }

        public bool CanGoBack
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_CanGoBack(ref value).ThrowOnError();
                return value;
            }
        }

        public bool CanGoForward
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_CanGoForward(ref value).ThrowOnError();
                return value;
            }
        }

        public string? DocumentTitle
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_DocumentTitle(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool ContainsFullScreenElement
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ContainsFullScreenElement(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
        public IComObject<ICoreWebView2CookieManager>? CookieManager
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_2>(instance) is not { } typed)
                    return default;

                typed.get_CookieManager(out ICoreWebView2CookieManager value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2CookieManager>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
        public IComObject<ICoreWebView2Environment>? Environment
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_2>(instance) is not { } typed)
                    return default;

                typed.get_Environment(out ICoreWebView2Environment value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2Environment>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
        public bool IsSuspended
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_3>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsSuspended(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_8"/>.</remarks>
        public bool IsMuted
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_8>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsMuted(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_8>(instance) is not { } typed)
                    return;

                typed.put_IsMuted(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_8"/>.</remarks>
        public bool IsDocumentPlayingAudio
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_8>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsDocumentPlayingAudio(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
        public bool IsDefaultDownloadDialogOpen
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_9>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_IsDefaultDownloadDialogOpen(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
        public COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT DefaultDownloadDialogCornerAlignment
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_9>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT value = default;
                typed.get_DefaultDownloadDialogCornerAlignment(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_9>(instance) is not { } typed)
                    return;

                typed.put_DefaultDownloadDialogCornerAlignment(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
        public POINT DefaultDownloadDialogMargin
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_9>(instance) is not { } typed)
                    return default;

                POINT value = default;
                typed.get_DefaultDownloadDialogMargin(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_9>(instance) is not { } typed)
                    return;

                typed.put_DefaultDownloadDialogMargin(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_12"/>.</remarks>
        public string? StatusBarText
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_12>(instance) is not { } typed)
                    return default;

                typed.get_StatusBarText(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_13"/>.</remarks>
        public IComObject<ICoreWebView2Profile>? Profile
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_13>(instance) is not { } typed)
                    return default;

                typed.get_Profile(out ICoreWebView2Profile value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2Profile>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_15"/>.</remarks>
        public string? FaviconUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_15>(instance) is not { } typed)
                    return default;

                typed.get_FaviconUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_19"/>.</remarks>
        public COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL MemoryUsageTargetLevel
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_19>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL value = default;
                typed.get_MemoryUsageTargetLevel(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_19>(instance) is not { } typed)
                    return;

                typed.put_MemoryUsageTargetLevel(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_20"/>.</remarks>
        public uint FrameId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_20>(instance) is not { } typed)
                    return default;

                uint value = default;
                typed.get_FrameId(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2_28"/>.</remarks>
        public IComObject<ICoreWebView2Find>? Find
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2_28>(instance) is not { } typed)
                    return default;

                typed.get_Find(out ICoreWebView2Find value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2Find>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2> instance)
    {
        public IComObject<ICoreWebView2Settings>? Settings
        {
            get => (instance?.Object!).Settings;
        }

        public string? Source
        {
            get => (instance?.Object!).Source;
        }

        public uint BrowserProcessId
        {
            get => (instance?.Object!).BrowserProcessId;
        }

        public bool CanGoBack
        {
            get => (instance?.Object!).CanGoBack;
        }

        public bool CanGoForward
        {
            get => (instance?.Object!).CanGoForward;
        }

        public string? DocumentTitle
        {
            get => (instance?.Object!).DocumentTitle;
        }

        public bool ContainsFullScreenElement
        {
            get => (instance?.Object!).ContainsFullScreenElement;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
        public IComObject<ICoreWebView2CookieManager>? CookieManager
        {
            get => (instance?.Object!).CookieManager;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_2"/>.</remarks>
        public IComObject<ICoreWebView2Environment>? Environment
        {
            get => (instance?.Object!).Environment;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_3"/>.</remarks>
        public bool IsSuspended
        {
            get => (instance?.Object!).IsSuspended;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_8"/>.</remarks>
        public bool IsMuted
        {
            get => (instance?.Object!).IsMuted;
            set => (instance?.Object!).IsMuted = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_8"/>.</remarks>
        public bool IsDocumentPlayingAudio
        {
            get => (instance?.Object!).IsDocumentPlayingAudio;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
        public bool IsDefaultDownloadDialogOpen
        {
            get => (instance?.Object!).IsDefaultDownloadDialogOpen;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
        public COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT DefaultDownloadDialogCornerAlignment
        {
            get => (instance?.Object!).DefaultDownloadDialogCornerAlignment;
            set => (instance?.Object!).DefaultDownloadDialogCornerAlignment = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_9"/>.</remarks>
        public POINT DefaultDownloadDialogMargin
        {
            get => (instance?.Object!).DefaultDownloadDialogMargin;
            set => (instance?.Object!).DefaultDownloadDialogMargin = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_12"/>.</remarks>
        public string? StatusBarText
        {
            get => (instance?.Object!).StatusBarText;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_13"/>.</remarks>
        public IComObject<ICoreWebView2Profile>? Profile
        {
            get => (instance?.Object!).Profile;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_15"/>.</remarks>
        public string? FaviconUri
        {
            get => (instance?.Object!).FaviconUri;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_19"/>.</remarks>
        public COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL MemoryUsageTargetLevel
        {
            get => (instance?.Object!).MemoryUsageTargetLevel;
            set => (instance?.Object!).MemoryUsageTargetLevel = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_20"/>.</remarks>
        public uint FrameId
        {
            get => (instance?.Object!).FrameId;
        }

        /// <remarks>Requires <see cref="ICoreWebView2_28"/>.</remarks>
        public IComObject<ICoreWebView2Find>? Find
        {
            get => (instance?.Object!).Find;
        }
    }
}
