#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ScriptExceptionExtensions
{
    extension(ICoreWebView2ScriptException instance)
    {
        public uint LineNumber
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_LineNumber(ref value).ThrowOnError();
                return value;
            }
        }

        public uint ColumnNumber
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_ColumnNumber(ref value).ThrowOnError();
                return value;
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

        public string? Message
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Message(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? ToJson
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ToJson(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2ScriptException> instance)
    {
        public uint LineNumber
        {
            get => (instance?.Object!).LineNumber;
        }

        public uint ColumnNumber
        {
            get => (instance?.Object!).ColumnNumber;
        }

        public string? Name
        {
            get => (instance?.Object!).Name;
        }

        public string? Message
        {
            get => (instance?.Object!).Message;
        }

        public string? ToJson
        {
            get => (instance?.Object!).ToJson;
        }
    }
}
