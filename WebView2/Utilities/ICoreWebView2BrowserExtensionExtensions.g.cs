#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2BrowserExtensionExtensions
{
    public static Task RemoveAsync(this ICoreWebView2BrowserExtension instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource();
        var hr = instance.Remove(new CoreWebView2BrowserExtensionRemoveCompletedHandler(errorCode =>
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

    public static Task EnableAsync(this ICoreWebView2BrowserExtension instance, bool isEnabled)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var tcs = new TaskCompletionSource();
        var hr = instance.Enable(isEnabled, new CoreWebView2BrowserExtensionEnableCompletedHandler(errorCode =>
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

    public static Task RemoveAsync(this IComObject<ICoreWebView2BrowserExtension> instance) => RemoveAsync(instance?.Object!);

    public static Task EnableAsync(this IComObject<ICoreWebView2BrowserExtension> instance, bool isEnabled) => EnableAsync(instance?.Object!, isEnabled);

    extension(ICoreWebView2BrowserExtension instance)
    {
        public string? Id
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Id(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Name
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Name(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public bool IsEnabled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsEnabled(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2BrowserExtension> instance)
    {
        public string? Id
        {
            get => (instance?.Object!).Id;
        }

        public string? Name
        {
            get => (instance?.Object!).Name;
        }

        public bool IsEnabled
        {
            get => (instance?.Object!).IsEnabled;
        }
    }
}
