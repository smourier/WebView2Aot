using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Win32InteropBuilder;
using Win32InteropBuilder.Generators;
using Win32InteropBuilder.Model;

namespace WebView2Aot.InteropBuilder.Cli;

public class Generator : CSharpGenerator
{
    private const string _methodNameKey = "methodName";
    private const string _returnTypeNameKey = "returnTypeName";

    private StringWriter? _signatureWriter;
    private List<GeneratedParameter>? _signatureParameters;

    public virtual MethodSignature GetSignature(BuilderContext context, BuilderType type, BuilderMethod method)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(type);
        ArgumentNullException.ThrowIfNull(method);

        var previousWriter = context.CurrentWriter;
        using var writer = new StringWriter();
        using var indentedWriter = new IndentedTextWriter(writer);
        var parameters = new List<GeneratedParameter>();
        _signatureWriter = writer;
        _signatureParameters = parameters;
        context.CurrentWriter = indentedWriter;
        try
        {
            var patch = context.Configuration.Patches?.Types?.FirstOrDefault(t => t.Matches(type));
            GenerateCode(context, type, patch, method);
            var methodName = method.GetExtendedValue<string>(_methodNameKey) ?? method.Name;
            var returnTypeName = method.GetExtendedValue<string>(_returnTypeNameKey) ?? string.Empty;
            return new MethodSignature(methodName, returnTypeName, parameters);
        }
        finally
        {
            context.CurrentWriter = previousWriter;
            _signatureWriter = null;
            _signatureParameters = null;
        }
    }

    protected override CSharpGeneratorParameter GenerateCode(
        BuilderContext context,
        BuilderType type,
        BuilderMethod method,
        BuilderPatchMethod? methodPatch,
        BuilderParameter parameter,
        int parameterIndex,
        CSharpGeneratorParameterOptions options)
    {
        if (_signatureWriter == null || _signatureParameters == null)
            return base.GenerateCode(context, type, method, methodPatch, parameter, parameterIndex, options);

        context.CurrentWriter?.Flush();
        var start = _signatureWriter.GetStringBuilder().Length;
        var generated = base.GenerateCode(context, type, method, methodPatch, parameter, parameterIndex, options);
        context.CurrentWriter?.Flush();
        var declaration = _signatureWriter.GetStringBuilder().ToString(start, _signatureWriter.GetStringBuilder().Length - start);
        _signatureParameters.Add(new GeneratedParameter(parameter, generated, declaration));
        return generated;
    }
}
