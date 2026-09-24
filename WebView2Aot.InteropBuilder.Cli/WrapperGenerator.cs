using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace WebView2Aot.InteropBuilder.Cli;

public partial class WrapperGenerator(BuilderContext context, Generator generator)
{
    internal const string _handlerSuffix = "Handler";
    internal const string _invokeMethodName = "Invoke";

    private const string _extensionsSuffix = "Extensions";
    private const string _eventsSuffix = "Events";
    private const string _generatedFileSuffix = ".g";
    private const string _nullableEnable = "#nullable enable";
    private const string _stringLocalSuffix = "Str";
    private const string _nativeLocalSuffix = "Native";
    private const string _tokenFieldSuffix = "Token";
    private const string _boolTypeName = "BOOL";
    private const string _streamTypeName = "IStream";
    private const string _variantTypeName = "VARIANT";
    private const string _iunknownName = "IUnknown";
    private const string _eventRegistrationTokenName = "EventRegistrationToken";
    private const string _getterPrefix = "get_";
    private const string _setterPrefix = "put_";
    private const string _addEventPrefix = "add_";
    private const string _removeEventPrefix = "remove_";
    private const string _countGetterName = "get_Count";
    private const string _valueAtIndexName = "GetValueAtIndex";
    private const string _moveNextName = "MoveNext";
    private const string _hasCurrentPrefix = "get_HasCurrent";
    private const string _getCurrentPrefix = "GetCurrent";
    private const string _utilitiesNamespace = Builder.Namespace + ".Utilities";
    private const string _directNUtilities = "DirectN.Extensions.Utilities.";
    private const string _directNCom = "DirectN.Extensions.Com.";
    private const string _objectTypeName = "object?";
    private const string _itemLocal = "item";
    private const string _valueParameterName = "value";
    private const string _resultParameterName = "result";
    private const string _instanceObject = "instance?.Object!";

    private const string _typedLocal = "typed";
    private const string _requiresDocFormat = "/// <remarks>Requires <see cref=\"{0}\"/>.</remarks>";
    private const string _utilitiesClassName = "WebView2Utilities";

    private static readonly HashSet<string> _syncReservedNames = ["instance", "hr", _typedLocal];
    private static readonly HashSet<string> _asyncReservedNames = ["instance", "hr", "tcs", "errorCode", "result", _typedLocal];

    private readonly Dictionary<BuilderMethod, MethodSignature> _signatures = [];
    private readonly HashSet<string> _handWrittenMembers = [];
    private HashSet<string>? _comInterfaceNames;
    private InterfaceType? _root;

    public virtual void Generate(string utilitiesPath, Action<BuilderType, string, string> write)
    {
        ArgumentNullException.ThrowIfNull(utilitiesPath);
        ArgumentNullException.ThrowIfNull(write);

        LoadHandWrittenMembers(utilitiesPath);
        var written = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var userWrite = write;
        write = (type, path, text) =>
        {
            written.Add(Path.GetFullPath(path));
            userWrite(type, path, text);
        };

        var families = new Dictionary<InterfaceType, List<InterfaceType>>();
        foreach (var typeName in context.TypesToBuild)
        {
            if (context.AllTypes[typeName] is not InterfaceType type || !type.IsIUnknownDerived || type.Name.EndsWith(_handlerSuffix))
                continue;

            var root = GetRootInterface(type);
            if (!families.TryGetValue(root, out var family))
            {
                family = [];
                families[root] = family;
            }
            family.Add(type);
        }

        var extension = context.Generator.FileExtension;
        foreach (var family in families.OrderBy(f => f.Key.Name))
        {
            var types = family.Value.OrderBy(GetInheritanceDepth).ToList();
            var extensions = GenerateExtensions(family.Key, types);
            if (extensions != null)
            {
                write(family.Key, Path.Combine(utilitiesPath, family.Key.Name + _extensionsSuffix + _generatedFileSuffix + extension), extensions);
            }

            var events = GenerateEvents(family.Key, types);
            if (events != null)
            {
                write(family.Key, Path.Combine(utilitiesPath, family.Key.Name[1..] + _eventsSuffix + extension), events);
            }
        }

        var unified = context.Configuration.Generation.Unified;
        if (unified.Namespace != null && unified.FunctionsFileName != null && context.TypesWithFunctions.Count > 0)
        {
            var members = new List<string>();
            foreach (var type in context.TypesWithFunctions.OrderBy(t => t.FullName))
            {
                foreach (var method in type.GeneratedMethods.OrderBy(m => m.Name))
                {
                    AddMethodMembers(members, type, method);
                }
            }

            if (members.Count > 0)
            {
                var text = WriteClass(unified.Namespace, $"public static partial class {unified.FunctionsFileName}", members);
                write(context.TypesWithFunctions.First(), Path.Combine(utilitiesPath, unified.FunctionsFileName + _generatedFileSuffix + extension), text);
            }
        }

        foreach (var path in Directory.EnumerateFiles(utilitiesPath, "*" + _generatedFileSuffix + extension))
        {
            if (!written.Contains(Path.GetFullPath(path)))
            {
                context.LogVerbose($"Deleting stale generated file '{path}'.");
                File.Delete(path);
            }
        }
    }

    protected virtual MethodSignature GetSignature(BuilderType type, BuilderMethod method)
    {
        if (!_signatures.TryGetValue(method, out var signature))
        {
            signature = generator.GetSignature(context, type, method);
            _signatures[method] = signature;
        }
        return signature;
    }

    private InterfaceType? GetBaseInterface(InterfaceType type)
    {
        if (type.Interfaces.Count != 1)
            return null;

        return context.AllTypes.TryGetValue(type.Interfaces[0], out var baseType) && baseType is InterfaceType it && it.Name != _iunknownName ? it : null;
    }

    private InterfaceType GetRootInterface(InterfaceType type)
    {
        while (GetBaseInterface(type) is { } baseType)
        {
            type = baseType;
        }
        return type;
    }

    private int GetInheritanceDepth(InterfaceType type)
    {
        var depth = 0;
        while (GetBaseInterface(type) is { } baseType)
        {
            type = baseType;
            depth++;
        }
        return depth;
    }

    private InterfaceType? GetCompletedHandler(BuilderMethod method)
    {
        if (method.Parameters.Count == 0 || method.ReturnTypeFullName?.Name != FullName.HRESULT.Name)
            return null;

        var last = method.Parameters[^1];
        if (last.TypeFullName == null ||
            !context.TypesToBuild.Contains(last.TypeFullName) ||
            !context.AllTypes.TryGetValue(last.TypeFullName, out var type) ||
            type is not InterfaceType handler ||
            !handler.Name.EndsWith(_handlerSuffix) ||
            handler.Methods.Count != 1 ||
            handler.Methods[0].Name != _invokeMethodName)
            return null;

        var invoke = handler.Methods[0];
        if (invoke.Parameters.Count < 1 || invoke.Parameters.Count > 2 || invoke.Parameters[0].TypeFullName?.Name != FullName.HRESULT.Name)
            return null;

        return handler;
    }

    private string? GenerateExtensions(InterfaceType root, List<InterfaceType> types)
    {
        _root = root;
        try
        {
            var members = new List<string>();
            var forwarders = new List<string>();
            var properties = new List<string>();
            var mirrors = new List<string>();
            foreach (var type in types)
            {
                foreach (var method in type.Methods)
                {
                    AddMethodMembers(members, type, method, forwarders);
                }

                members.AddRange(GenerateCollectionMethods(type, forwarders));
                GenerateProperties(type, properties, mirrors);
            }

            members.AddRange(forwarders);
            AddIfNotNull(members, WritePropertyBlocks(root, properties, mirrors));
            if (members.Count == 0)
                return null;

            return WriteClass(_utilitiesNamespace, $"public static partial class {root.Name}{_extensionsSuffix}", members);
        }
        finally
        {
            _root = null;
        }
    }

    private string? GetRequiresDoc(BuilderType type) => IsVersioned(type) ? string.Format(_requiresDocFormat, type.Name) : null;

    private void WriteRequiresDoc(IndentedTextWriter iw, BuilderType type)
    {
        var doc = GetRequiresDoc(type);
        if (doc != null)
        {
            iw.WriteLine(doc);
        }
    }

    private string GetReceiverName(BuilderType type) => (_root ?? type).Name;
    private bool IsVersioned(BuilderType type) => _root != null && type != _root;
    private string GetTarget(BuilderType type) => IsVersioned(type) ? _typedLocal + "." : "instance.";

    private void WriteVersionCheck(IndentedTextWriter iw, BuilderType type, IReadOnlyList<string> earlyExit)
    {
        if (!IsVersioned(type))
            return;

        iw.WriteLine($"if ({_utilitiesClassName}.GetInterface<{type.Name}>(instance) is not {{ }} {_typedLocal})");
        if (earlyExit.Count == 1)
        {
            iw.Indent++;
            iw.WriteLine(earlyExit[0]);
            iw.Indent--;
        }
        else
        {
            iw.WriteLine("{");
            iw.Indent++;
            foreach (var line in earlyExit)
            {
                iw.WriteLine(line);
            }

            iw.Indent--;
            iw.WriteLine("}");
        }

        WriteBlankLine(iw);
    }

    private void AddMethodMembers(List<string> members, BuilderType type, BuilderMethod method, List<string>? forwarders = null)
    {
        var signature = GetSignature(type, method);
        AddIfNotNull(members, GenerateWrapper(type, method, signature, forwarders));

        var handler = GetCompletedHandler(method);
        if (handler != null)
        {
            AddIfNotNull(members, GenerateAsync(type, method, signature, handler, forwarders));
        }
    }

    private string GenerateForwarder(string returnTypeName, string name, string instanceTypeName, IEnumerable<string> declarations, string? doc = null)
    {
        var list = new List<string>();
        var arguments = new List<string>();
        foreach (var declaration in declarations)
        {
            var parts = declaration.Split(' ');
            var parameterName = parts[^1];
            if (parts[0] is GeneratedParameter._inKeyword or GeneratedParameter._outKeyword or GeneratedParameter._refKeyword)
            {
                list.Add(declaration);
                arguments.Add(parts[0] + " " + parameterName);
                continue;
            }

            var typeName = declaration[..declaration.LastIndexOf(' ')];
            if (IsComInterface(typeName))
            {
                var isNullable = typeName.EndsWith('?');
                list.Add($"{GetComObjectTypeName(typeName)[..^(isNullable ? 0 : 1)]} {parameterName}");
                arguments.Add(isNullable ? $"{parameterName}?.Object" : $"{parameterName}?.Object!");
                continue;
            }

            list.Add(declaration);
            arguments.Add(parameterName);
        }

        list.Insert(0, $"this IComObject<{instanceTypeName}> instance");
        arguments.Insert(0, _instanceObject);
        var line = $"public static {returnTypeName} {name}({string.Join(", ", list)}) => {name}({string.Join(", ", arguments)});";
        return doc != null ? doc + Environment.NewLine + line : line;
    }

    private void LoadHandWrittenMembers(string utilitiesPath)
    {
        if (!Directory.Exists(utilitiesPath))
            return;

        foreach (var path in Directory.EnumerateFiles(utilitiesPath, "*" + context.Generator.FileExtension))
        {
            if (path.EndsWith(_generatedFileSuffix + context.Generator.FileExtension, StringComparison.OrdinalIgnoreCase))
                continue;

            foreach (Match match in HandWrittenMemberRegex().Matches(File.ReadAllText(path)))
            {
                _handWrittenMembers.Add(GetMemberKey(match.Groups["receiver"].Value, match.Groups["name"].Value, CountParameters(match.Groups["parameters"].Value)));
            }
        }
    }

    private static int CountParameters(string parameters)
    {
        if (string.IsNullOrWhiteSpace(parameters))
            return 0;

        var count = 1;
        var depth = 0;
        foreach (var c in parameters)
        {
            switch (c)
            {
                case '<':
                case '(':
                    depth++;
                    break;

                case '>':
                case ')':
                    depth--;
                    break;

                case ',' when depth == 0:
                    count++;
                    break;
            }
        }
        return count;
    }

    private static string GetMemberKey(string receiver, string name, int parameterCount) => $"{receiver}.{name}/{parameterCount}";
    private bool IsHandWritten(string receiver, string name, int parameterCount) => _handWrittenMembers.Contains(GetMemberKey(receiver, name, parameterCount));

    [GeneratedRegex(@"public\s+static\s+[^\s(]+(?:<[^>]*>)?\??\s+(?<name>\w+)(?:<[^>]*>)?\(\s*this\s+(?<receiver>[\w.]+(?:<[^>]*>)?)\s+\w+\s*,?\s*(?<parameters>[^)]*)\)")]
    private static partial Regex HandWrittenMemberRegex();

    private static bool IsDotNetShaped(IEnumerable<string> declarations) =>
        !declarations.Any(d => d.StartsWith(GeneratedParameter._inKeyword + " ") || NativeShapeRegex().IsMatch(d));

    [GeneratedRegex($@"\b(PWSTR|VARIANT|nint|{_eventRegistrationTokenName}|\w+{_handlerSuffix})\b")]
    private static partial Regex NativeShapeRegex();

    private static bool IsPropertyAccessor(BuilderMethod method, MethodSignature signature) =>
        signature.Parameters.Count == 1 && (method.Name.StartsWith(_getterPrefix) || method.Name.StartsWith(_setterPrefix));

    private static bool IsEventAccessor(BuilderMethod method) =>
        method.Name.StartsWith(_addEventPrefix) || method.Name.StartsWith(_removeEventPrefix);

    private static void AddIfNotNull(List<string> members, string? member)
    {
        if (member != null)
        {
            members.Add(member);
        }
    }

    private static bool IsStream(string typeName) => typeName.TrimEnd('?') == _streamTypeName;
    private static bool IsUnknown(string typeName) => typeName.TrimEnd('?') == _iunknownName;
    private static string GetUnknownPrologue(string name, string local) =>
        $"using var {local} = {_directNCom}ComObject.FromPointer<{_iunknownName}>({_directNCom}ComObject.GetOrCreateComInstance({name}, throwOnError: true));";
    private static string GetComObjectTypeName(string typeName) => $"IComObject<{typeName.TrimEnd('?')}>?";
    private static string GetComObjectExpression(string typeName, string local) => $"{local} != null ? new ComObject<{typeName.TrimEnd('?')}>({local}) : null";

    private bool IsComInterface(string typeName)
    {
        _comInterfaceNames ??= [.. context.AllTypes.Values.OfType<InterfaceType>().Where(t => t.IsIUnknownDerived && t.Name != _streamTypeName).Select(t => t.Name).Append(_iunknownName)];
        return _comInterfaceNames.Contains(typeName.TrimEnd('?'));
    }

    private WrappedParameters? WrapParameters(BuilderType type, BuilderMethod method, IEnumerable<GeneratedParameter> parameters, bool isAsync)
    {
        var reservedNames = isAsync ? _asyncReservedNames : _syncReservedNames;
        var isGetter = method.Name.StartsWith(_getterPrefix);
        var wrapped = new WrappedParameters();
        var list = parameters.ToList();
        foreach (var parameter in list)
        {
            var name = parameter.Name;
            var isOutputByName = parameter == list[^1] && name is _valueParameterName or _resultParameterName;
            if (reservedNames.Contains(name))
                throw new NotSupportedException($"Method '{type.Name}.{method.Name}' has a parameter named '{name}' which is reserved for wrapper generation.");

            var keyword = parameter.Keyword;
            var typeName = parameter.TypeName;
            if (isAsync && keyword is GeneratedParameter._outKeyword or GeneratedParameter._refKeyword)
                return null;

            if (keyword == null && typeName == FullName.PWSTR.Name)
            {
                var local = name + _stringLocalSuffix;
                wrapped.Prologue.Add($"using var {local} = new {_directNUtilities}Pwstr({name});");
                wrapped.AddConverted($"string? {name}", local);
                continue;
            }

            if (keyword == null && typeName == _boolTypeName)
            {
                wrapped.AddConverted($"bool {name}", name);
                continue;
            }

            if (keyword == null && IsStream(typeName))
            {
                if (typeName.EndsWith('?'))
                {
                    wrapped.AddConverted($"Stream? {name}", $"{name} != null ? new {_directNUtilities}ManagedIStream({name}) : null");
                }
                else
                {
                    wrapped.AddConverted($"Stream {name}", $"new {_directNUtilities}ManagedIStream({name})");
                }
                continue;
            }

            if (keyword == null && IsUnknown(typeName))
            {
                var local = name + _nativeLocalSuffix;
                wrapped.Prologue.Add(GetUnknownPrologue(name, local));
                wrapped.AddConverted($"{_objectTypeName} {name}", $"{local}?.Object!");
                continue;
            }

            if (keyword != null && keyword != GeneratedParameter._inKeyword && GetOutputValue(parameter, name + _nativeLocalSuffix) is { } output &&
                (output.TypeName != typeName || (keyword == GeneratedParameter._refKeyword && (isGetter || isOutputByName))))
            {
                if (output.Prologue != null)
                {
                    wrapped.Prologue.Add(output.Prologue);
                }

                wrapped.AddConverted($"out {output.TypeName} {name}", output.Argument);
                wrapped.Epilogue.Add($"{name} = {output.Expression};");
                continue;
            }

            var prefix = keyword != null ? keyword + " " : null;
            wrapped.AddPassThrough($"{prefix}{typeName} {name}", $"{prefix}{name}");
        }
        return wrapped;
    }

    private OutputValue? GetOutputValue(GeneratedParameter parameter, string local)
    {
        var typeName = parameter.TypeName;
        switch (parameter.Keyword)
        {
            case GeneratedParameter._outKeyword when typeName == FullName.PWSTR.Name:
                return new OutputValue("string?", $"out PWSTR {local}", $"{local}.ToStringAndDispose()", null);

            case GeneratedParameter._outKeyword when IsStream(typeName):
                return new OutputValue("Stream?", $"out IStream {local}", $"{local} != null ? new {_directNUtilities}StreamOnIStream({local}, true) : null", null, true);

            case GeneratedParameter._outKeyword when IsComInterface(typeName):
                return new OutputValue(GetComObjectTypeName(typeName), $"out {typeName} {local}", GetComObjectExpression(typeName, local), null, true);

            case GeneratedParameter._outKeyword:
                return new OutputValue(typeName, $"out {typeName} {local}", local, null);

            case GeneratedParameter._refKeyword when typeName == _boolTypeName:
                return new OutputValue("bool", $"ref {local}", local, $"var {local} = BOOL.FALSE;");

            case GeneratedParameter._refKeyword when typeName != _variantTypeName:
                return new OutputValue(typeName, $"ref {local}", local, $"{typeName} {local} = default;");

            default:
                return null;
        }
    }

    private string? GenerateWrapper(BuilderType type, BuilderMethod method, MethodSignature signature, List<string>? forwarders)
    {
        if (signature.ReturnTypeName != FullName.HRESULT.Name || IsPropertyAccessor(method, signature) || IsEventAccessor(method))
            return null;

        var name = signature.Name;
        var wrapped = WrapParameters(type, method, signature.Parameters, false);
        if (wrapped == null)
            return null;

        var declarations = wrapped.Declarations.ToList();
        var returnTypeName = "void";
        string? returnName = null;
        var outputs = declarations.Where(d => d.StartsWith(GeneratedParameter._outKeyword + " ") || d.StartsWith(GeneratedParameter._refKeyword + " ")).ToList();
        if (outputs.Count == 1 && outputs[0] == declarations[^1] && outputs[0].StartsWith(GeneratedParameter._outKeyword + " "))
        {
            var typeAndName = outputs[0][(GeneratedParameter._outKeyword.Length + 1)..];
            var space = typeAndName.LastIndexOf(' ');
            returnTypeName = typeAndName[..space];
            returnName = typeAndName[(space + 1)..];
            declarations.RemoveAt(declarations.Count - 1);
        }

        if (!IsDotNetShaped(declarations))
            return null;

        var instanceType = type as InterfaceType;
        var receiverName = GetReceiverName(type);
        if (instanceType != null && IsHandWritten(receiverName, name, declarations.Count))
            return null;

        if (forwarders != null && instanceType != null && !IsHandWritten($"IComObject<{receiverName}>", name, declarations.Count))
        {
            forwarders.Add(GenerateForwarder(returnTypeName, name, receiverName, declarations, GetRequiresDoc(type)));
        }

        if (instanceType == null && !wrapped.HasConversion && returnName == null)
            return null;

        var earlyExit = declarations
            .Where(d => d.StartsWith(GeneratedParameter._outKeyword + " "))
            .Select(d => $"{d[(d.LastIndexOf(' ') + 1)..]} = default;")
            .Append(returnName != null ? "return default;" : "return;")
            .ToList();

        if (instanceType != null)
        {
            declarations.Insert(0, $"this {receiverName} instance");
        }

        var target = instanceType != null ? GetTarget(type) : null;
        return Write(iw =>
        {
            WriteRequiresDoc(iw, type);
            iw.WriteLine($"public static {returnTypeName} {name}({string.Join(", ", declarations)})");
            iw.WriteLine("{");
            iw.Indent++;
            if (instanceType != null)
            {
                iw.WriteLine("ArgumentNullException.ThrowIfNull(instance);");
                WriteBlankLine(iw);
                WriteVersionCheck(iw, type, earlyExit);
            }

            if (returnName != null)
            {
                iw.WriteLine($"{returnTypeName} {returnName};");
            }

            foreach (var line in wrapped.Prologue)
            {
                iw.WriteLine(line);
            }

            iw.WriteLine($"{target}{signature.Name}({string.Join(", ", wrapped.Arguments)}).ThrowOnError();");
            foreach (var line in wrapped.Epilogue)
            {
                iw.WriteLine(line);
            }

            if (returnName != null)
            {
                iw.WriteLine($"return {returnName};");
            }

            iw.Indent--;
            iw.WriteLine("}");
        });
    }

    private string? GenerateAsync(BuilderType type, BuilderMethod method, MethodSignature signature, InterfaceType handler, List<string>? forwarders)
    {
        var wrapped = WrapParameters(type, method, signature.Parameters.Take(signature.Parameters.Count - 1), true);
        if (wrapped == null)
            return null;

        var invoke = handler.Methods[0];
        string? resultTypeName = null;
        string? setResult = null;
        if (invoke.Parameters.Count == 2)
        {
            resultTypeName = invoke.Parameters[1].TypeFullName!.Name;
            setResult = "result";
            if (resultTypeName == FullName.PWSTR.Name)
            {
                resultTypeName = "string?";
                setResult = "result.ToString()";
            }
            else if (resultTypeName == _boolTypeName)
            {
                resultTypeName = "bool";
            }
            else if (IsStream(resultTypeName))
            {
                resultTypeName = "Stream?";
                setResult = $"result != null ? new {_directNUtilities}StreamOnIStream(result, true) : null";
            }
            else if (IsComInterface(resultTypeName))
            {
                setResult = GetComObjectExpression(resultTypeName, "result");
                resultTypeName = GetComObjectTypeName(resultTypeName);
            }
        }

        var taskTypeName = resultTypeName != null ? $"Task<{resultTypeName}>" : "Task";
        var tcsTypeName = resultTypeName != null ? $"TaskCompletionSource<{resultTypeName}>" : "TaskCompletionSource";
        var lambdaParameters = resultTypeName != null ? "(errorCode, result)" : "errorCode";
        var handlerClsName = handler.Name[1..];
        var instanceType = type as InterfaceType;
        var receiverName = GetReceiverName(type);
        if (forwarders != null && instanceType != null)
        {
            forwarders.Add(GenerateForwarder(taskTypeName, signature.Name + "Async", receiverName, wrapped.Declarations, GetRequiresDoc(type)));
        }

        var declarations = wrapped.Declarations.ToList();
        if (instanceType != null)
        {
            declarations.Insert(0, $"this {receiverName} instance");
        }

        var earlyExit = resultTypeName != null ? $"return Task.FromResult<{resultTypeName}>(default!);" : "return Task.CompletedTask;";
        var target = instanceType != null ? GetTarget(type) : null;
        return Write(iw =>
        {
            WriteRequiresDoc(iw, type);
            iw.WriteLine($"public static {taskTypeName} {signature.Name}Async({string.Join(", ", declarations)})");
            iw.WriteLine("{");
            iw.Indent++;
            if (instanceType != null)
            {
                iw.WriteLine("ArgumentNullException.ThrowIfNull(instance);");
                WriteBlankLine(iw);
                WriteVersionCheck(iw, type, [earlyExit]);
            }

            foreach (var line in wrapped.Prologue)
            {
                iw.WriteLine(line);
            }

            iw.WriteLine($"var tcs = new {tcsTypeName}();");
            iw.WriteLine($"var hr = {target}{signature.Name}({string.Join(", ", wrapped.Arguments.Append($"new {handlerClsName}({lambdaParameters} =>"))}");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine("if (errorCode.IsError)");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine("tcs.TrySetException(Marshal.GetExceptionForHR(errorCode)!);");
            iw.WriteLine("return;");
            iw.Indent--;
            iw.WriteLine("}");
            WriteBlankLine(iw);
            iw.WriteLine($"tcs.TrySetResult({setResult});");
            iw.Indent--;
            iw.WriteLine("}));");
            WriteBlankLine(iw);
            iw.WriteLine("if (hr.IsError)");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine("tcs.TrySetException(Marshal.GetExceptionForHR(hr)!);");
            iw.Indent--;
            iw.WriteLine("}");
            WriteBlankLine(iw);
            iw.WriteLine("return tcs.Task;");
            iw.Indent--;
            iw.WriteLine("}");
        });
    }

    private void GenerateProperties(InterfaceType type, List<string> properties, List<string> mirrors)
    {
        var target = GetTarget(type);
        foreach (var getter in type.Methods.Where(m => m.Name.StartsWith(_getterPrefix)))
        {
            var signature = GetSignature(type, getter);
            if (signature.ReturnTypeName != FullName.HRESULT.Name || signature.Parameters.Count != 1)
                continue;

            var output = GetOutputValue(signature.Parameters[0], "value");
            if (output == null)
                continue;

            var name = getter.Name[_getterPrefix.Length..];
            var propertyTypeName = HasUnknownSetter(type, name) ? _objectTypeName : output.TypeName;
            var setter = GetSetter(type, name, propertyTypeName, target);
            mirrors.Add(Write(iw =>
            {
                WriteRequiresDoc(iw, type);
                iw.WriteLine($"public {propertyTypeName} {name}");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine($"get => ({_instanceObject}).{name};");
                if (setter != null)
                {
                    iw.WriteLine($"set => ({_instanceObject}).{name} = value;");
                }

                iw.Indent--;
                iw.WriteLine("}");
            }));

            properties.Add(Write(iw =>
            {
                WriteRequiresDoc(iw, type);
                iw.WriteLine($"public {propertyTypeName} {name}");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine("get");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine("ArgumentNullException.ThrowIfNull(instance);");
                WriteBlankLine(iw);
                WriteVersionCheck(iw, type, ["return default;"]);
                if (output.Prologue != null)
                {
                    iw.WriteLine(output.Prologue);
                }

                iw.WriteLine($"{target}{signature.Name}({output.Argument}).ThrowOnError();");
                iw.WriteLine($"return {output.Expression};");
                iw.Indent--;
                iw.WriteLine("}");
                if (setter != null)
                {
                    WriteBlankLine(iw);
                    iw.WriteLine("set");
                    iw.WriteLine("{");
                    iw.Indent++;
                    iw.WriteLine("ArgumentNullException.ThrowIfNull(instance);");
                    WriteBlankLine(iw);
                    WriteVersionCheck(iw, type, ["return;"]);
                    foreach (var line in setter)
                    {
                        iw.WriteLine(line);
                    }

                    iw.Indent--;
                    iw.WriteLine("}");
                }

                iw.Indent--;
                iw.WriteLine("}");
            }));
        }

    }

    private static string? WritePropertyBlocks(InterfaceType root, List<string> properties, List<string> mirrors)
    {
        if (properties.Count == 0)
            return null;

        return Write(iw =>
        {
            iw.WriteLine($"extension({root.Name} instance)");
            iw.WriteLine("{");
            iw.Indent++;
            WriteMembers(iw, properties);
            iw.Indent--;
            iw.WriteLine("}");
            WriteBlankLine(iw);
            iw.WriteLine($"extension(IComObject<{root.Name}> instance)");
            iw.WriteLine("{");
            iw.Indent++;
            WriteMembers(iw, mirrors);
            iw.Indent--;
            iw.WriteLine("}");
        });
    }

    private bool HasUnknownSetter(InterfaceType type, string name)
    {
        var method = type.Methods.FirstOrDefault(m => m.Name == _setterPrefix + name);
        if (method == null)
            return false;

        var parameters = GetSignature(type, method).Parameters;
        return parameters.Count == 1 && parameters[0].Keyword == null && IsUnknown(parameters[0].TypeName);
    }

    private List<string>? GetSetter(InterfaceType type, string name, string propertyTypeName, string target)
    {
        var method = type.Methods.FirstOrDefault(m => m.Name == _setterPrefix + name);
        if (method == null)
            return null;

        var signature = GetSignature(type, method);
        if (signature.ReturnTypeName != FullName.HRESULT.Name || signature.Parameters.Count != 1 || signature.Parameters[0].Keyword != null)
            return null;

        var typeName = signature.Parameters[0].TypeName;
        if (typeName == FullName.PWSTR.Name)
        {
            if (propertyTypeName != "string?")
                return null;

            return
            [
                $"using var valueStr = new {_directNUtilities}Pwstr(value);",
                $"{target}{signature.Name}(valueStr).ThrowOnError();",
            ];
        }

        if (typeName == _boolTypeName)
        {
            if (propertyTypeName != "bool")
                return null;

            return [$"{target}{signature.Name}(value).ThrowOnError();"];
        }

        if (IsStream(typeName))
        {
            if (propertyTypeName != "Stream?")
                return null;

            return [$"{target}{signature.Name}(value != null ? new {_directNUtilities}ManagedIStream(value) : null!).ThrowOnError();"];
        }

        if (IsUnknown(typeName))
        {
            if (propertyTypeName != _objectTypeName)
                return null;

            return
            [
                GetUnknownPrologue(_valueParameterName, _valueParameterName + _nativeLocalSuffix),
                $"{target}{signature.Name}({_valueParameterName}{_nativeLocalSuffix}?.Object!).ThrowOnError();",
            ];
        }

        if (IsComInterface(typeName))
        {
            if (propertyTypeName != GetComObjectTypeName(typeName))
                return null;

            return [$"{target}{signature.Name}(value?.Object!).ThrowOnError();"];
        }

        if (typeName.TrimEnd('?') != propertyTypeName.TrimEnd('?'))
            return null;

        return [$"{target}{signature.Name}(value).ThrowOnError();"];
    }

    private IEnumerable<string> GenerateCollectionMethods(InterfaceType type, List<string> forwarders)
    {
        var collection = GetListCollection(type) ?? GetIteratorCollection(type);
        if (collection == null)
            yield break;

        forwarders.Add(GenerateForwarder($"IReadOnlyList<{collection.ItemTypeName}>", "ToList", type.Name, []));
        forwarders.Add(GenerateForwarder("void", "ForEach", type.Name, [$"Action<{collection.ItemTypeName}> action"]));

        yield return Write(iw =>
        {
            iw.WriteLine($"public static IReadOnlyList<{collection.ItemTypeName}> ToList(this {type.Name} instance)");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine("ArgumentNullException.ThrowIfNull(instance);");
            WriteBlankLine(iw);
            iw.WriteLine($"var list = new List<{collection.ItemTypeName}>();");
            collection.WriteLoop(iw, () => iw.WriteLine("list.Add(item);"));
            WriteBlankLine(iw);
            iw.WriteLine("return list;");
            iw.Indent--;
            iw.WriteLine("}");
        });

        yield return Write(iw =>
        {
            iw.WriteLine($"public static void ForEach(this {type.Name} instance, Action<{collection.ItemTypeName}> action)");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine("ArgumentNullException.ThrowIfNull(instance);");
            iw.WriteLine("ArgumentNullException.ThrowIfNull(action);");
            WriteBlankLine(iw);
            collection.WriteLoop(iw, () =>
            {
                if (!collection.IsDisposableItem)
                {
                    iw.WriteLine("action(item);");
                    return;
                }

                iw.WriteLine("try");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine("action(item);");
                iw.Indent--;
                iw.WriteLine("}");
                iw.WriteLine("finally");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine("item?.Dispose();");
                iw.Indent--;
                iw.WriteLine("}");
            });
            iw.Indent--;
            iw.WriteLine("}");
        });
    }

    private WrappedCollection? GetListCollection(InterfaceType type)
    {
        var countMethod = type.Methods.FirstOrDefault(m => m.Name == _countGetterName);
        var itemMethod = type.Methods.FirstOrDefault(m => m.Name == _valueAtIndexName);
        if (countMethod == null || itemMethod == null)
            return null;

        var countSignature = GetSignature(type, countMethod);
        var itemSignature = GetSignature(type, itemMethod);
        if (countSignature.Parameters.Count != 1 || itemSignature.Parameters.Count != 2 || itemSignature.Parameters[0].Keyword != null)
            return null;

        var count = GetOutputValue(countSignature.Parameters[0], "count");
        var item = GetItemOutputValue(itemSignature.Parameters[1], _itemLocal);
        if (count == null || item == null)
            return null;

        return new WrappedCollection(item.TypeName, item.IsDisposable, (iw, writeBody) =>
        {
            if (count.Prologue != null)
            {
                iw.WriteLine(count.Prologue);
            }

            iw.WriteLine($"instance.{countSignature.Name}({count.Argument}).ThrowOnError();");
            iw.WriteLine($"for (var i = 0; i < {count.Expression}; i++)");
            iw.WriteLine("{");
            iw.Indent++;
            if (item.Prologue != null)
            {
                iw.WriteLine(item.Prologue);
            }

            iw.WriteLine($"instance.{itemSignature.Name}(({itemSignature.Parameters[0].TypeName})i, {item.Argument}).ThrowOnError();");
            WriteItemAssignment(iw, item.Expression);
            writeBody();
            iw.Indent--;
            iw.WriteLine("}");
        });
    }

    private WrappedCollection? GetIteratorCollection(InterfaceType type)
    {
        var moveNextMethod = type.Methods.FirstOrDefault(m => m.Name == _moveNextName);
        var hasCurrentMethod = type.Methods.FirstOrDefault(m => m.Name.StartsWith(_hasCurrentPrefix));
        var getCurrentMethod = type.Methods.FirstOrDefault(m => m.Name.StartsWith(_getCurrentPrefix));
        if (moveNextMethod == null || hasCurrentMethod == null || getCurrentMethod == null)
            return null;

        var moveNextSignature = GetSignature(type, moveNextMethod);
        var hasCurrentSignature = GetSignature(type, hasCurrentMethod);
        var getCurrentSignature = GetSignature(type, getCurrentMethod);
        if (!isBoolOutput(moveNextSignature) || !isBoolOutput(hasCurrentSignature))
            return null;

        var values = getCurrentSignature.Parameters.Count == 1 ?
            [GetItemOutputValue(getCurrentSignature.Parameters[0], _itemLocal)] :
            getCurrentSignature.Parameters.Select((p, i) => GetOutputValue(p, _itemLocal + i + _nativeLocalSuffix)).ToList();
        if (values.Count is < 1 or > 2 || values.Any(v => v == null))
            return null;

        string itemTypeName;
        string itemExpression;
        if (values.Count == 1)
        {
            itemTypeName = values[0]!.TypeName;
            itemExpression = values[0]!.Expression;
        }
        else
        {
            itemTypeName = $"KeyValuePair<{values[0]!.TypeName}, {values[1]!.TypeName}>";
            itemExpression = $"new {itemTypeName}({values[0]!.Expression}, {values[1]!.Expression})";
        }

        return new WrappedCollection(itemTypeName, values.Count == 1 && values[0]!.IsDisposable, (iw, writeBody) =>
        {
            iw.WriteLine("while (true)");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine("var hasCurrent = BOOL.FALSE;");
            iw.WriteLine($"instance.{hasCurrentSignature.Name}(ref hasCurrent).ThrowOnError();");
            iw.WriteLine("if (!hasCurrent)");
            iw.Indent++;
            iw.WriteLine("break;");
            iw.Indent--;
            WriteBlankLine(iw);
            foreach (var value in values)
            {
                if (value!.Prologue != null)
                {
                    iw.WriteLine(value.Prologue);
                }
            }

            iw.WriteLine($"instance.{getCurrentSignature.Name}({string.Join(", ", values.Select(v => v!.Argument))}).ThrowOnError();");
            WriteItemAssignment(iw, itemExpression);
            writeBody();
            WriteBlankLine(iw);
            iw.WriteLine("var hasNext = BOOL.FALSE;");
            iw.WriteLine($"instance.{moveNextSignature.Name}(ref hasNext).ThrowOnError();");
            iw.WriteLine("if (!hasNext)");
            iw.Indent++;
            iw.WriteLine("break;");
            iw.Indent--;
            iw.Indent--;
            iw.WriteLine("}");
        });

        static bool isBoolOutput(MethodSignature signature) =>
            signature.Parameters.Count == 1 &&
            signature.Parameters[0].Keyword == GeneratedParameter._refKeyword &&
            signature.Parameters[0].TypeName == _boolTypeName;
    }

    private OutputValue? GetItemOutputValue(GeneratedParameter parameter, string local)
    {
        var direct = GetOutputValue(parameter, local);
        if (direct == null || direct.Expression == local)
            return direct;

        var native = GetOutputValue(parameter, local + _nativeLocalSuffix)!;
        if (!IsComInterface(parameter.TypeName))
            return native;

        return new OutputValue(native.TypeName.TrimEnd('?'), native.Argument, $"({native.Expression})!", native.Prologue, native.IsDisposable);
    }

    private static void WriteItemAssignment(IndentedTextWriter iw, string expression)
    {
        if (expression != _itemLocal)
        {
            iw.WriteLine($"var {_itemLocal} = {expression};");
        }
    }

    private sealed class WrappedCollection(string itemTypeName, bool isDisposableItem, Action<IndentedTextWriter, Action> writeLoop)
    {
        public string ItemTypeName => itemTypeName;
        public bool IsDisposableItem => isDisposableItem;
        public void WriteLoop(IndentedTextWriter iw, Action writeBody) => writeLoop(iw, writeBody);
    }

    private string? GenerateEvents(InterfaceType root, List<InterfaceType> types)
    {
        var events = new List<WrappedEvent>();
        foreach (var type in types)
        {
            foreach (var adder in type.Methods.Where(m => m.Name.StartsWith(_addEventPrefix)))
            {
                var name = adder.Name[_addEventPrefix.Length..];
                var remover = type.Methods.FirstOrDefault(m => m.Name == _removeEventPrefix + name);
                if (remover == null || events.Any(e => e.Name == name))
                    continue;

                var adderSignature = GetSignature(type, adder);
                var removerSignature = GetSignature(type, remover);
                if (adderSignature.Parameters.Count != 2 ||
                    adderSignature.Parameters[1].Keyword != GeneratedParameter._refKeyword ||
                    adderSignature.Parameters[1].TypeName != _eventRegistrationTokenName ||
                    removerSignature.Parameters.Count != 1)
                    continue;

                var handlerTypeName = adder.Parameters[0].TypeFullName;
                if (handlerTypeName == null ||
                    !context.AllTypes.TryGetValue(handlerTypeName, out var handlerType) ||
                    handlerType is not InterfaceType handler ||
                    handler.Methods.Count != 1 ||
                    handler.Methods[0].Parameters.Count != 2)
                    continue;

                var argsTypeName = handler.Methods[0].Parameters[1].TypeFullName!.Name;
                events.Add(new WrappedEvent(type, name, adderSignature.Name, removerSignature.Name, handler.Name[1..], argsTypeName == _iunknownName ? null : argsTypeName));
            }
        }

        if (events.Count == 0)
            return null;

        var clsName = root.Name[1..] + _eventsSuffix;
        return Write(iw =>
        {
            iw.WriteLine($"namespace {_utilitiesNamespace};");
            iw.WriteLine();
            iw.WriteLine($"public sealed class {clsName}({root.Name} instance) : IDisposable");
            iw.WriteLine("{");
            iw.Indent++;
            iw.WriteLine($"private readonly {root.Name} _instance = instance ?? throw new ArgumentNullException(nameof(instance));");
            foreach (var e in events)
            {
                var field = getFieldName(e.Name);
                iw.WriteLine($"private {getDelegateTypeName(e)}? {field};");
                iw.WriteLine($"private EventRegistrationToken {field}{_tokenFieldSuffix};");
            }

            WriteBlankLine(iw);
            iw.WriteLine($"public {clsName}(IComObject<{root.Name}> instance)");
            iw.Indent++;
            iw.WriteLine(": this(instance?.Object!)");
            iw.Indent--;
            iw.WriteLine("{");
            iw.WriteLine("}");
            WriteBlankLine(iw);
            iw.WriteLine($"public {root.Name} Instance => _instance;");
            foreach (var e in events)
            {
                var field = getFieldName(e.Name);
                var args = e.ArgsTypeName != null ? "args" : "EventArgs.Empty";
                var adder = e.Type == root ? "_instance" : _typedLocal;
                WriteBlankLine(iw);
                if (e.Type != root)
                {
                    iw.WriteLine(string.Format(_requiresDocFormat, e.Type.Name));
                }

                iw.WriteLine($"public event {getDelegateTypeName(e)}? {e.Name}");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine("add");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine($"if ({field} == null)");
                iw.WriteLine("{");
                iw.Indent++;
                if (e.Type != root)
                {
                    iw.WriteLine($"if ({_utilitiesClassName}.GetInterface<{e.Type.Name}>(_instance) is not {{ }} {_typedLocal})");
                    iw.Indent++;
                    iw.WriteLine("return;");
                    iw.Indent--;
                    WriteBlankLine(iw);
                }

                iw.WriteLine($"{adder}.{e.AdderName}(new {e.HandlerClassName}((sender, args) => {field}?.Invoke(sender, {args})), ref {field}{_tokenFieldSuffix}).ThrowOnError();");
                iw.Indent--;
                iw.WriteLine("}");
                WriteBlankLine(iw);
                iw.WriteLine($"{field} += value;");
                iw.Indent--;
                iw.WriteLine("}");
                iw.WriteLine("remove");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine($"{field} -= value;");
                iw.WriteLine($"if ({field} == null)");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine($"{getRemoverTarget(e)}.{e.RemoverName}({field}{_tokenFieldSuffix});");
                iw.Indent--;
                iw.WriteLine("}");
                iw.Indent--;
                iw.WriteLine("}");
                iw.Indent--;
                iw.WriteLine("}");
            }

            WriteBlankLine(iw);
            iw.WriteLine("public void Dispose()");
            iw.WriteLine("{");
            iw.Indent++;
            for (var i = 0; i < events.Count; i++)
            {
                var e = events[i];
                var field = getFieldName(e.Name);
                iw.WriteLine($"if ({field} != null)");
                iw.WriteLine("{");
                iw.Indent++;
                iw.WriteLine($"{field} = null;");
                iw.WriteLine($"{getRemoverTarget(e)}.{e.RemoverName}({field}{_tokenFieldSuffix});");
                iw.Indent--;
                iw.WriteLine("}");
                if (i != events.Count - 1)
                {
                    WriteBlankLine(iw);
                }
            }

            iw.Indent--;
            iw.WriteLine("}");
            iw.Indent--;
            iw.WriteLine("}");
        });

        static string getFieldName(string name) => "_" + char.ToLowerInvariant(name[0]) + name[1..];
        static string getDelegateTypeName(WrappedEvent e) => e.ArgsTypeName != null ? $"EventHandler<{e.ArgsTypeName}>" : "EventHandler";
        string getRemoverTarget(WrappedEvent e) => e.Type == root ? "_instance" : $"{_utilitiesClassName}.GetInterface<{e.Type.Name}>(_instance)?";
    }

    private static string WriteClass(string ns, string declaration, List<string> members) => Write(iw =>
    {
        iw.WriteLine(_nullableEnable);
        iw.WriteLine($"namespace {ns};");
        iw.WriteLine();
        iw.WriteLine(declaration);
        iw.WriteLine("{");
        iw.Indent++;
        WriteMembers(iw, members);
        iw.Indent--;
        iw.WriteLine("}");
    });

    private static void WriteMembers(IndentedTextWriter iw, List<string> members)
    {
        for (var i = 0; i < members.Count; i++)
        {
            if (i > 0)
            {
                WriteBlankLine(iw);
            }

            foreach (var line in members[i].TrimEnd().Split(Environment.NewLine))
            {
                if (line.Length == 0)
                {
                    WriteBlankLine(iw);
                }
                else
                {
                    iw.WriteLine(line);
                }
            }
        }
    }

    private static void WriteBlankLine(IndentedTextWriter iw) => iw.WriteLineNoTabs(string.Empty);

    private static string Write(Action<IndentedTextWriter> write)
    {
        using var writer = new StringWriter();
        using var iw = new IndentedTextWriter(writer);
        write(iw);
        iw.Flush();
        return writer.ToString();
    }
}
