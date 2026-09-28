#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FrameExtensions
{
    public static HRESULT RemoveHostObjectFromScript(this ICoreWebView2Frame instance, string? name, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        return instance.RemoveHostObjectFromScript(nameStr).ThrowOnError(throwOnError);
    }

    public static bool IsDestroyed(this ICoreWebView2Frame instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        bool destroyed;
        var destroyedNative = BOOL.FALSE;
        instance.IsDestroyed(ref destroyedNative).ThrowOnError();
        destroyed = destroyedNative;
        return destroyed;
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static Task<string?> ExecuteScriptAsync(this ICoreWebView2Frame instance, string? javaScript)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(instance) is not { } typed)
            return Task.FromResult<string?>(default!);

        using var javaScriptStr = new DirectN.Extensions.Utilities.Pwstr(javaScript);
        var tcs = new TaskCompletionSource<string?>();
        var hr = typed.ExecuteScript(javaScriptStr, new CoreWebView2ExecuteScriptCompletedHandler((errorCode, result) =>
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

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static HRESULT PostWebMessageAsJson(this ICoreWebView2Frame instance, string? webMessageAsJson, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        using var webMessageAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsJson);
        return typed.PostWebMessageAsJson(webMessageAsJsonStr).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static HRESULT PostWebMessageAsString(this ICoreWebView2Frame instance, string? webMessageAsString, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        using var webMessageAsStringStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsString);
        return typed.PostWebMessageAsString(webMessageAsStringStr).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame4"/>.</remarks>
    public static HRESULT PostSharedBufferToScript(this ICoreWebView2Frame instance, ICoreWebView2SharedBuffer sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, string? additionalDataAsJson, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Frame4>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        using var additionalDataAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(additionalDataAsJson);
        return typed.PostSharedBufferToScript(sharedBuffer, access, additionalDataAsJsonStr).ThrowOnError(throwOnError);
    }

    public static HRESULT RemoveHostObjectFromScript(this IComObject<ICoreWebView2Frame> instance, string? name, bool throwOnError = true) => RemoveHostObjectFromScript(instance?.Object!, name, throwOnError);

    public static bool IsDestroyed(this IComObject<ICoreWebView2Frame> instance) => IsDestroyed(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static Task<string?> ExecuteScriptAsync(this IComObject<ICoreWebView2Frame> instance, string? javaScript) => ExecuteScriptAsync(instance?.Object!, javaScript);

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static HRESULT PostWebMessageAsJson(this IComObject<ICoreWebView2Frame> instance, string? webMessageAsJson, bool throwOnError = true) => PostWebMessageAsJson(instance?.Object!, webMessageAsJson, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static HRESULT PostWebMessageAsString(this IComObject<ICoreWebView2Frame> instance, string? webMessageAsString, bool throwOnError = true) => PostWebMessageAsString(instance?.Object!, webMessageAsString, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2Frame4"/>.</remarks>
    public static HRESULT PostSharedBufferToScript(this IComObject<ICoreWebView2Frame> instance, IComObject<ICoreWebView2SharedBuffer> sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, string? additionalDataAsJson, bool throwOnError = true) => PostSharedBufferToScript(instance?.Object!, sharedBuffer?.Object!, access, additionalDataAsJson, throwOnError);

    extension(ICoreWebView2Frame instance)
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

        /// <remarks>Requires <see cref="ICoreWebView2Frame5"/>.</remarks>
        public uint FrameId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Frame5>(instance) is not { } typed)
                    return default;

                uint value = default;
                typed.get_FrameId(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2Frame> instance)
    {
        public string? Name
        {
            get => (instance?.Object!).Name;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Frame5"/>.</remarks>
        public uint FrameId
        {
            get => (instance?.Object!).FrameId;
        }
    }
}
