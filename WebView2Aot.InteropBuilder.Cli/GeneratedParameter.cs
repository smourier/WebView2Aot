using System.Text.RegularExpressions;
using Win32InteropBuilder.Generators;
using Win32InteropBuilder.Model;

namespace WebView2Aot.InteropBuilder.Cli;

public sealed partial class GeneratedParameter(BuilderParameter parameter, CSharpGeneratorParameter generated, string declaration)
{
    internal const string _inKeyword = "in";
    internal const string _outKeyword = "out";
    internal const string _refKeyword = "ref";

    public BuilderParameter Parameter => parameter;
    public CSharpGeneratorParameter Generated => generated;
    public string Declaration => declaration;
    public string Name => generated.Name;
    public string TypeName => generated.TypeName;
    public string? Keyword { get; } = GetKeyword(declaration);

    private static string? GetKeyword(string declaration)
    {
        var text = AttributesRegex().Replace(CommentsRegex().Replace(declaration, string.Empty), string.Empty).Trim();
        var first = text.Split(' ')[0];
        return first is _inKeyword or _outKeyword or _refKeyword ? first : null;
    }

    [GeneratedRegex(@"/\*.*?\*/")]
    private static partial Regex CommentsRegex();

    [GeneratedRegex(@"\[[^\]]*\]")]
    private static partial Regex AttributesRegex();
}
