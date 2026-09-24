namespace WebView2Aot.InteropBuilder.Cli;

internal sealed class OutputValue(string typeName, string argument, string expression, string? prologue, bool isDisposable = false)
{
    public string TypeName => typeName;
    public string Argument => argument;
    public string Expression => expression;
    public string? Prologue => prologue;
    public bool IsDisposable => isDisposable;
}
