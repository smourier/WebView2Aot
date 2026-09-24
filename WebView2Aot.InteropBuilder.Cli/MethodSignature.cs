using System.Collections.Generic;

namespace WebView2Aot.InteropBuilder.Cli;

public sealed class MethodSignature(string name, string returnTypeName, IReadOnlyList<GeneratedParameter> parameters)
{
    public string Name => name;
    public string ReturnTypeName => returnTypeName;
    public IReadOnlyList<GeneratedParameter> Parameters => parameters;
}
