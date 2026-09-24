namespace WebView2.Utilities;

public static class ICoreWebView2Extensions
{
    public static Task<string?> ExecuteScriptAsJon(this ICoreWebView2 webView, string javaScript, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(webView);
        ArgumentNullException.ThrowIfNull(javaScript);

        var tcs = new TaskCompletionSource<string?>();
        using var javaScriptStr = new DirectN.Extensions.Utilities.Pwstr(javaScript);
        HRESULT hr;
        if (webView is not ICoreWebView2_21 wv21)
        {
            hr = webView.ExecuteScript(javaScriptStr, new CoreWebView2ExecuteScriptCompletedHandler((result, jsonPtr) =>
            {
                if (result.IsError)
                {
                    SetError(tcs, result, null, throwOnError);
                    return;
                }

                tcs.SetResult(jsonPtr.ToString());
            }));
        }
        else
        {
            hr = wv21.ExecuteScriptWithResult(javaScriptStr, new CoreWebView2ExecuteScriptWithResultCompletedHandler((result, p) =>
            {
                if (result.IsError)
                {
                    SetError(tcs, result, null, throwOnError);
                    return;
                }

                var succeeded = BOOL.FALSE;
                p.get_Succeeded(ref succeeded);
                if (!succeeded)
                {
                    p.get_Exception(out var error);
                    var exception = CoreWebView2ScriptException.From(error);
                    if (exception != null && throwOnError)
                    {
                        tcs.SetException(exception);
                    }
                    else
                    {
                        tcs.SetResult(null);
                    }
                    return;
                }

                p.get_ResultAsJson(out var jsonPtr);
                if (jsonPtr.Value == 0)
                {
                    tcs.SetResult(null);
                    return;
                }

                var json = jsonPtr.ToString()!;
                Marshal.FreeCoTaskMem(jsonPtr.Value);
                tcs.SetResult(json);
            }));
        }

        if (hr.IsError)
        {
            SetError(tcs, hr, null, throwOnError);
        }
        return tcs.Task;
    }

    public static Task<T?> ExecuteScript<T>(this ICoreWebView2 webView, string javaScript, JsonTypeInfo<T> typeInfo, T? defaultValue = default, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(webView);
        ArgumentNullException.ThrowIfNull(javaScript);
        ArgumentNullException.ThrowIfNull(typeInfo);

        var tcs = new TaskCompletionSource<T?>();
        using var javaScriptStr = new DirectN.Extensions.Utilities.Pwstr(javaScript);
        HRESULT hr;
        if (webView is not ICoreWebView2_21 wv21)
        {
            hr = webView.ExecuteScript(javaScriptStr, new CoreWebView2ExecuteScriptCompletedHandler((result, jsonPtr) =>
            {
                if (result.IsError)
                {
                    SetError(tcs, result, defaultValue, throwOnError);
                    return;
                }

                if (jsonPtr.Value == 0)
                {
                    tcs.SetResult(defaultValue);
                    return;
                }

                var json = jsonPtr.ToString()!;
                tcs.SetResult(JsonSerializer.Deserialize(json, typeInfo) ?? defaultValue);
            }));
        }
        else
        {
            hr = wv21.ExecuteScriptWithResult(javaScriptStr, new CoreWebView2ExecuteScriptWithResultCompletedHandler((result, p) =>
            {
                if (result.IsError)
                {
                    SetError(tcs, result, defaultValue, throwOnError);
                    return;
                }

                var succeeded = BOOL.FALSE;
                p.get_Succeeded(ref succeeded);
                if (!succeeded)
                {
                    p.get_Exception(out var error);
                    var exception = CoreWebView2ScriptException.From(error);
                    if (exception != null && throwOnError)
                    {
                        tcs.SetException(exception);
                    }
                    else
                    {
                        tcs.SetResult(defaultValue);
                    }
                    return;
                }

                p.get_ResultAsJson(out var jsonPtr);
                if (jsonPtr.Value == 0)
                {
                    tcs.SetResult(defaultValue);
                    return;
                }

                var json = jsonPtr.ToString()!;
                Marshal.FreeCoTaskMem(jsonPtr.Value);
                tcs.SetResult(JsonSerializer.Deserialize(json, typeInfo) ?? defaultValue);
            }));
        }

        if (hr.IsError)
        {
            SetError(tcs, hr, defaultValue, throwOnError);
        }
        return tcs.Task;
    }

    private static void SetError<T>(TaskCompletionSource<T> tcs, HRESULT hr, T value, bool throwOnError)
    {
        if (throwOnError)
        {
            tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);
        }
        else
        {
            tcs.TrySetResult(value);
        }
    }
}
