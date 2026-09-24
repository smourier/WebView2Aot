using Win32InteropBuilder.Model;

namespace WebView2Aot.InteropBuilder.Cli;

internal sealed class WrappedEvent(InterfaceType type, string name, string adderName, string removerName, string handlerClassName, string? argsTypeName)
{
    public InterfaceType Type => type;
    public string Name => name;
    public string AdderName => adderName;
    public string RemoverName => removerName;
    public string HandlerClassName => handlerClassName;
    public string? ArgsTypeName => argsTypeName;
}
