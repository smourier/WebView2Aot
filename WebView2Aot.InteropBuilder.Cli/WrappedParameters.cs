using System.Collections.Generic;

namespace WebView2Aot.InteropBuilder.Cli;

internal sealed class WrappedParameters
{
    public List<string> Declarations { get; } = [];
    public List<string> Arguments { get; } = [];
    public List<string> Prologue { get; } = [];
    public List<string> Epilogue { get; } = [];
    public bool HasConversion { get; private set; }

    public void AddConverted(string declaration, string argument)
    {
        Declarations.Add(declaration);
        Arguments.Add(argument);
        HasConversion = true;
    }

    public void AddPassThrough(string declaration, string argument)
    {
        Declarations.Add(declaration);
        Arguments.Add(argument);
    }
}
