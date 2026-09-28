#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ExecuteScriptResultExtensions
{
    public static HRESULT TryGetResultAsString(this ICoreWebView2ExecuteScriptResult instance, out string? stringResult, out bool value, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var valueNative = BOOL.FALSE;
        var hr = instance.TryGetResultAsString(out PWSTR stringResultNative, ref valueNative).ThrowOnError(throwOnError);
        stringResult = stringResultNative.ToStringAndDispose();
        value = valueNative;
        return hr;
    }

    public static HRESULT TryGetResultAsString(this IComObject<ICoreWebView2ExecuteScriptResult> instance, out string? stringResult, out bool value, bool throwOnError = true) => TryGetResultAsString(instance?.Object!, out stringResult, out value, throwOnError);

    extension(ICoreWebView2ExecuteScriptResult instance)
    {
        public bool Succeeded
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_Succeeded(ref value).ThrowOnError();
                return value;
            }
        }

        public string? ResultAsJson
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ResultAsJson(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public IComObject<ICoreWebView2ScriptException>? Exception
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Exception(out ICoreWebView2ScriptException value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ScriptException>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2ExecuteScriptResult> instance)
    {
        public bool Succeeded
        {
            get => (instance?.Object!).Succeeded;
        }

        public string? ResultAsJson
        {
            get => (instance?.Object!).ResultAsJson;
        }

        public IComObject<ICoreWebView2ScriptException>? Exception
        {
            get => (instance?.Object!).Exception;
        }
    }
}
