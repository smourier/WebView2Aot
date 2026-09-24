#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FrameExtensions
{
    public static void RemoveHostObjectFromScript(this ICoreWebView2Frame instance, string? name)
    {
        ArgumentNullException.ThrowIfNull(instance);

        using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
        instance.RemoveHostObjectFromScript(nameStr).ThrowOnError();
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
    public static void PostWebMessageAsJson(this ICoreWebView2Frame instance, string? webMessageAsJson)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(instance) is not { } typed)
            return;

        using var webMessageAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsJson);
        typed.PostWebMessageAsJson(webMessageAsJsonStr).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static void PostWebMessageAsString(this ICoreWebView2Frame instance, string? webMessageAsString)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Frame2>(instance) is not { } typed)
            return;

        using var webMessageAsStringStr = new DirectN.Extensions.Utilities.Pwstr(webMessageAsString);
        typed.PostWebMessageAsString(webMessageAsStringStr).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2Frame4"/>.</remarks>
    public static void PostSharedBufferToScript(this ICoreWebView2Frame instance, ICoreWebView2SharedBuffer sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, string? additionalDataAsJson)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2Frame4>(instance) is not { } typed)
            return;

        using var additionalDataAsJsonStr = new DirectN.Extensions.Utilities.Pwstr(additionalDataAsJson);
        typed.PostSharedBufferToScript(sharedBuffer, access, additionalDataAsJsonStr).ThrowOnError();
    }

    public static void RemoveHostObjectFromScript(this IComObject<ICoreWebView2Frame> instance, string? name) => RemoveHostObjectFromScript(instance?.Object!, name);

    public static bool IsDestroyed(this IComObject<ICoreWebView2Frame> instance) => IsDestroyed(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static Task<string?> ExecuteScriptAsync(this IComObject<ICoreWebView2Frame> instance, string? javaScript) => ExecuteScriptAsync(instance?.Object!, javaScript);

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static void PostWebMessageAsJson(this IComObject<ICoreWebView2Frame> instance, string? webMessageAsJson) => PostWebMessageAsJson(instance?.Object!, webMessageAsJson);

    /// <remarks>Requires <see cref="ICoreWebView2Frame2"/>.</remarks>
    public static void PostWebMessageAsString(this IComObject<ICoreWebView2Frame> instance, string? webMessageAsString) => PostWebMessageAsString(instance?.Object!, webMessageAsString);

    /// <remarks>Requires <see cref="ICoreWebView2Frame4"/>.</remarks>
    public static void PostSharedBufferToScript(this IComObject<ICoreWebView2Frame> instance, IComObject<ICoreWebView2SharedBuffer> sharedBuffer, COREWEBVIEW2_SHARED_BUFFER_ACCESS access, string? additionalDataAsJson) => PostSharedBufferToScript(instance?.Object!, sharedBuffer?.Object!, access, additionalDataAsJson);

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
