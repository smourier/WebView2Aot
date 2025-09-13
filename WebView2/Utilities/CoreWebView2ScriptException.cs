namespace WebView2.Utilities;

[Serializable]
public class CoreWebView2ScriptException : Exception
{
    public CoreWebView2ScriptException()
    {
    }

    public CoreWebView2ScriptException(string message)
        : base(message)
    {
    }

    public CoreWebView2ScriptException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public CoreWebView2ScriptException(string message, uint lineNumber, uint columnNumber, string name, string json)
    : base(message)
    {
        LineNumber = lineNumber;
        ColumnNumber = columnNumber;
        Name = name;
        Json = json;
    }

    public string? Name { get; }
    public uint LineNumber { get; }
    public uint ColumnNumber { get; }
    public string? Json { get; }

    public static CoreWebView2ScriptException? From(ICoreWebView2ScriptException? error)
    {
        if (error == null)
            return null;

        uint lineNumber = 0;
        error.get_LineNumber(ref lineNumber).ThrowOnError();
        error.get_Message(out var message).ThrowOnError();
        error.get_Name(out var name).ThrowOnError();
        uint columnNumber = 0;
        error.get_ColumnNumber(ref columnNumber).ThrowOnError();
        error.get_ToJson(out var json).ThrowOnError();
        var exception = new CoreWebView2ScriptException(
            message.ToString() ?? "Error",
            lineNumber,
            columnNumber,
            name.ToString() ?? string.Empty,
            json.ToString() ?? string.Empty
        );
        Marshal.FreeCoTaskMem(message.Value);
        Marshal.FreeCoTaskMem(name.Value);
        Marshal.FreeCoTaskMem(json.Value);
        return exception;
    }
}

