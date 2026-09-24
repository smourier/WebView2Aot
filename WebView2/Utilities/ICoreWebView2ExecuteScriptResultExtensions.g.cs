#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ExecuteScriptResultExtensions
{
    public static void TryGetResultAsString(this ICoreWebView2ExecuteScriptResult instance, out string? stringResult, out bool value)
    {
        ArgumentNullException.ThrowIfNull(instance);

        var valueNative = BOOL.FALSE;
        instance.TryGetResultAsString(out PWSTR stringResultNative, ref valueNative).ThrowOnError();
        stringResult = stringResultNative.ToStringAndDispose();
        value = valueNative;
    }

    public static void TryGetResultAsString(this IComObject<ICoreWebView2ExecuteScriptResult> instance, out string? stringResult, out bool value) => TryGetResultAsString(instance?.Object!, out stringResult, out value);

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
