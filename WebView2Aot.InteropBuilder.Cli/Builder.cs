using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;
using Win32InteropBuilder.Utilities;

namespace WebView2Aot.InteropBuilder.Cli;

public partial class Builder : Win32InteropBuilder.Builder
{
    public const string Namespace = "WebView2";
    public const string ProjectName = "WebView2";

    private const string _eventHandlerSuffix = "EventHandler";
    private const string _senderParameterName = "sender";

    private readonly HashSet<string> _alreadyIncludedTypes = [];

    public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration, IGenerator generator)
    {
        ArgumentNullException.ThrowIfNull(configuration);
        ArgumentNullException.ThrowIfNull(generator);

        configuration.OutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ProjectName, "Generated"));
        var context = new Context(configuration, generator);
        context.ImplicitNamespaces.Add(Namespace);
        return context;
    }

    protected override void ExcludeTypesFromBuild(BuilderContext context)
    {
        base.ExcludeTypesFromBuild(context);

        if (_alreadyIncludedTypes.Count == 0)
        {
            foreach (var type in typeof(DirectN.VARIANT).Assembly.GetTypes())
            {
                if (type.IsPublic)
                {
                    _alreadyIncludedTypes.Add(type.Name);
                }
            }
        }

        var typeNamesToBuild = new Dictionary<string, List<FullName>>();
        foreach (var type in context.TypesToBuild)
        {
            var name = type.Name;
            if (type.NestedName != null)
            {
                name = name[..type.Name.IndexOf('+')];
            }

            if (!typeNamesToBuild.TryGetValue(name, out var list))
            {
                list = [];
                typeNamesToBuild[name] = list;
            }
            list.Add(type);
        }

        foreach (var type in _alreadyIncludedTypes)
        {
            if (typeNamesToBuild.Remove(type, out var list))
            {
                foreach (var item in list)
                {
                    context.TypesToBuild.Remove(item);
                }
            }
        }
    }

    protected override void GenerateTypes(BuilderContext context)
    {
        base.GenerateTypes(context);

        if (context.Generator is not Generator generator)
            throw new InvalidOperationException($"The generator must be '{typeof(Generator).AssemblyQualifiedName}'.");

        var utilitiesPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ProjectName, "Utilities"));
        foreach (var typeName in context.TypesToBuild)
        {
            var type = context.AllTypes[typeName];
            if (type is InterfaceType it && typeName.Name.EndsWith(WrapperGenerator._handlerSuffix))
            {
                var clsName = new FullName(type.Namespace, typeName.Name[1..]);
                using var writer = new StringWriter();
                GenerateEventHandle(writer, clsName, it);
                WriteUtilitiesFile(context, type, Path.Combine(utilitiesPath, clsName.Name + context.Generator.FileExtension), writer.ToString());
            }
        }

        new WrapperGenerator(context, generator).Generate(utilitiesPath, (type, path, text) => WriteUtilitiesFile(context, type, path, text));
    }

    private static void WriteUtilitiesFile(BuilderContext context, BuilderType type, string typePath, string text)
    {
        if (IOUtilities.PathIsFile(typePath))
        {
            var existingText = EncodingDetector.ReadAllText(typePath, context.Configuration.EncodingDetectorMode, out _);

            // remove ws for comparison to avoid stupid git mangling with end-of-lines
            if (text.EqualsWithoutWhitespaces(existingText))
                return;
        }

        IOUtilities.FileEnsureDirectory(typePath);

        context.LogVerbose(type + " => " + typePath);
        File.WriteAllText(typePath, text, context.Configuration.FinalOutputEncoding);
    }

    private static void GenerateEventHandle(TextWriter writer, FullName clsName, InterfaceType type)
    {
        if (type.Methods.Count != 1 || type.Methods[0].Name != WrapperGenerator._invokeMethodName)
            return;

        var invoke = type.Methods[0];
        var iw = new IndentedTextWriter(writer);
        iw.WriteLine("namespace WebView2.Utilities;");
        iw.WriteLine();
        iw.WriteLine("[GeneratedComClass]");
        iw.WriteLine($"public partial class {clsName.Name}(Action<{string.Join(", ", invoke.Parameters.Select(p => p.TypeFullName!.Name))}> handler)");
        iw.Indent++;
        iw.WriteLine($": {type.Name}");
        iw.Indent--;
        iw.WriteLine("{");
        iw.Indent++;
        iw.WriteLine($"public virtual HRESULT Invoke({string.Join(", ", invoke.Parameters.Select(p => $"{p.TypeFullName!.Name} {p.Name}"))})");
        iw.WriteLine("{");
        iw.Indent++;
        var call = "handler(" + string.Join(", ", invoke.Parameters.Select(p => p.Name)) + ");";
        var sender = invoke.Parameters.FirstOrDefault(p => p.Name == _senderParameterName);
        if (type.Name.EndsWith(_eventHandlerSuffix) && sender != null && sender.TypeFullName?.Name != WrapperGenerator._iunknownName)
        {
            iw.WriteLine("try");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine(call);
            iw.Indent--;
            iw.WriteLine("}");
            iw.WriteLine("finally");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine($"{WrapperGenerator._directNCom}ComObject.FinalRelease((object){_senderParameterName} as System.Runtime.InteropServices.Marshalling.ComObject);");
            iw.Indent--;
            iw.WriteLine("}");
            iw.WriteLineNoTabs(string.Empty);
        }
        else
        {
            iw.WriteLine(call);
        }

        iw.WriteLine("return 0;");
        iw.Indent--;
        iw.WriteLine("}");
        iw.Indent--;
        iw.WriteLine("}");
    }
}
