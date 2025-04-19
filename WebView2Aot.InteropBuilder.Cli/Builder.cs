using System.Collections.Generic;
using System.IO;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace WebView2Aot.InteropBuilder.Cli;

public partial class Builder : Win32InteropBuilder.Builder
{
    public const string Namespace = "WebView2";
    public const string ProjectName = "WebView2";

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

}
