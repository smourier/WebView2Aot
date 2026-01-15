using System.Runtime.InteropServices.Marshalling;
using DirectN.Extensions.Utilities;

namespace MarkdownViewer.Utilities;

// A generic base host object for the WebView2 control must implement IDispatch
// when we have say, this in javascript:
//
//         var options = JSON.parse(chrome.webview.hostObjects.dotnet.getInfo());
//
// 'dotnet' corresponds to this instance, and the WebView2 runtime will
//
// 1) call "dotnet" asking for a "getInfo" method or property
// 2) call this returned object's to do the function call (with 0 or more parameters). so only Invoke(0) should be called on this
//
// that's why we have two implementations of IDispatch here
[GeneratedComClass]
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties)]
public partial class DispatchObject : IDispatch
{
    private static readonly ConcurrentDictionary<Type, DispatchType> _cache = new();
    private const int _dispidBase = 1000;
    private static readonly string[] _reservedJavascriptNames =
    [
        "name", "constructor", "prototype", "toString", "valueOf", "hasOwnProperty", "isPrototypeOf", "propertyIsEnumerable", "toLocaleString"
    ];

    // if you throw here implement type in your GetTaskResult code.
    protected virtual object? GetTaskResult(Task task) => throw new NotSupportedException($"Type '{GetType().FullName}' returns a task of type '{task.GetType().FullName}'.");
    protected virtual TaskFunction CreateTaskFunction(MethodInfo method, object?[]? arguments) => new(this, method, arguments);

    // when working with WebView2 and the HostObjectHelper is installed, set this to true
    public virtual bool ContinueOnAsync { get; set; }

    // when working with WebView2 and the HostObjectHelper is installed, set this to true
    public virtual bool OneStepInvoke { get; set; }

    public bool IsMethod(string? name)
    {
        if (string.IsNullOrEmpty(name))
            return true;

        var type = GetType();
        if (!_cache.TryGetValue(type, out var dispatchType))
        {
            dispatchType = new DispatchType(type);
            _cache[type] = dispatchType;
        }

        return dispatchType.IsMethod(name) == true;
    }

    public bool IsAsync(string? name)
    {
        if (string.IsNullOrEmpty(name))
            return true;

        var type = GetType();
        if (!_cache.TryGetValue(type, out var dispatchType))
        {
            dispatchType = new DispatchType(type);
            _cache[type] = dispatchType;
        }

        return dispatchType.IsAsync(name) == true;
    }

    HRESULT IDispatch.GetIDsOfNames(in Guid riid, PWSTR[] rgszNames, uint cNames, uint lcid, int[] rgDispId) =>
        GetIDsOfNames(in riid, rgszNames, cNames, lcid, rgDispId);

    protected virtual HRESULT GetIDsOfNames(in Guid riid, PWSTR[] rgszNames, uint cNames, uint lcid, int[] rgDispId)
    {
        if (rgszNames == null || rgszNames.Length == 0 || rgszNames.Length != cNames)
            return DirectN.Constants.E_INVALIDARG;

        var type = GetType();
        for (var i = 0; i < cNames; i++)
        {
            var name = rgszNames[i].ToString();
            if (name == null)
            {
                rgDispId[i] = -1;
                continue;
            }

            //DirectN.Extensions.Utilities.Application.TraceVerbose($"looking for '{name}' in '{type.FullName}'");
            if (!_cache.TryGetValue(type, out var dispatchType))
            {
                dispatchType = new DispatchType(type);
                _cache[type] = dispatchType;
            }

            var dispId = dispatchType.GetDispId(name);
            if (dispId < 0)
            {
                DirectN.Extensions.Utilities.Application.TraceError($"DISP_E_UNKNOWNNAME {GetType().FullName} {name}");
            }

            rgDispId[i] = dispId < 0 ? -1 : dispId + _dispidBase;
        }

        if (rgDispId.Any(id => id == -1))
        {
            const int DISP_E_UNKNOWNNAME = unchecked((int)0x80020006);
            return DISP_E_UNKNOWNNAME;
        }

        //DirectN.Extensions.Utilities.Application.TraceVerbose($"S_OK");
        return DirectN.Constants.S_OK;
    }

    HRESULT IDispatch.Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr) =>
        Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);

    protected virtual unsafe HRESULT Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr)
    {
        try
        {
            var type = GetType();
            if (!_cache.TryGetValue(type, out var dispatchType) || dispatchType.GetMethod(dispIdMember - _dispidBase) is not MethodInfo method || method == null)
            {
                DirectN.Extensions.Utilities.Application.TraceError($"DISP_E_MEMBERNOTFOUND {GetType().FullName} {dispIdMember}");
                const int DISP_E_MEMBERNOTFOUND = unchecked((int)0x80020003);
                return DISP_E_MEMBERNOTFOUND;
            }

            var isAsync = ContinueOnAsync && DispatchType.IsAsync(method);
            if (isAsync)
            {
                var tf = CreateTaskFunction(method, Function.BuildArguments(method, pDispParams));
                using var vatf = new Variant(tf);
                vatf.DetachTo(pVarResult);
                return DirectN.Constants.S_OK;
            }

            if (OneStepInvoke)
            {
                var arguments = Function.BuildArguments(method, pDispParams);
                var result = method.Invoke(this, arguments);
                return Function.WriteResultAsVARIANT(result, pVarResult);
            }

            var func = new Function(this, method);
            using var va = new Variant(func);
            va.DetachTo(pVarResult);
            return DirectN.Constants.S_OK;
        }
        catch (Exception ex)
        {
            DirectN.Extensions.Utilities.Application.TraceError($" Exception: {ex}");
            if (pExcepInfo != 0)
            {
                var excepInfo = new EXCEPINFO
                {
                    bstrSource = new(Marshal.StringToBSTR(GetType().FullName)),
                    scode = ex.HResult,
                    bstrDescription = new(Marshal.StringToBSTR(ex.ToString())),
                };

                *(EXCEPINFO*)pExcepInfo = excepInfo;
            }
            return DirectN.Constants.E_FAIL;
        }
    }

    HRESULT IDispatch.GetTypeInfo(uint iTInfo, uint lcid, out ITypeInfo ppTInfo) => throw new NotSupportedException();
    HRESULT IDispatch.GetTypeInfoCount(out uint pctinfo)
    {
        pctinfo = 0;
        return DirectN.Constants.S_OK;
    }

    public static Window GetWindow()
    {
        var windows = DirectN.Extensions.Utilities.Application.GetApplication(Environment.CurrentManagedThreadId)?.Windows;
        if (windows == null || windows.Count == 0)
            throw new InvalidAsynchronousStateException();

        var window = windows.FirstOrDefault(w => w.TaskScheduler != null && !w.IsBackground) ?? windows.FirstOrDefault(w => w.TaskScheduler != null);
        return window ?? throw new InvalidAsynchronousStateException();
    }

    [GeneratedComClass]
    public partial class TaskFunction(DispatchObject obj, MethodInfo method, object?[]? arguments) : IUnknown
    {
        public virtual unsafe void Continue(Func<HRESULT, VARIANT, HRESULT> continuation)
        {
            ArgumentNullException.ThrowIfNull(continuation);
            try
            {
                var result = method.Invoke(obj, arguments);
                if (result is Task task) // it *should* be a task if we're here but just in case
                {
                    switch (task.Status)
                    {
                        case TaskStatus.RanToCompletion:
                            break;

                        case TaskStatus.Canceled:
                            break;

                        case TaskStatus.Faulted:
                            break;

                        case TaskStatus.Created:
                        case TaskStatus.WaitingForActivation:
                        case TaskStatus.WaitingToRun:
                        case TaskStatus.Running:
                        case TaskStatus.WaitingForChildrenToComplete:
                            var awaiter = task.GetAwaiter();
                            awaiter.OnCompleted(() =>
                            {
                                try
                                {
                                    result = obj.GetTaskResult(task);
                                    var v = new VARIANT();
                                    var hr = Function.WriteResultAsVARIANT(result, (nint)(&v));
                                    continuation.Invoke(hr, v).ThrowOnError();
                                }
                                catch (Exception ex)
                                {
                                    DirectN.Extensions.Utilities.Application.TraceError($"OnCompleted Exception: {ex}");
                                }
                            });
                            return;
                    }

                    result = obj.GetTaskResult(task);
                }

                var v = new VARIANT();
                var hr = Function.WriteResultAsVARIANT(result, (nint)(&v));
                continuation.Invoke(hr, v).ThrowOnError();
            }
            catch (Exception ex)
            {
                DirectN.Extensions.Utilities.Application.TraceError($"Exception: {ex}");
                continuation.Invoke(ex.HResult, new VARIANT()).ThrowOnError();
            }
        }
    }

    private sealed class DispatchType
    {
        private readonly Dictionary<string, Dispid> _methods = new(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<int, MethodInfo> _getMethods = [];

        public DispatchType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties)] Type type)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (var method in methods)
            {
                if (method.Attributes.HasFlag(MethodAttributes.SpecialName)) // like get_ / set_ / add_ / remove_ / etc.
                    continue;

                var browsable = method.GetCustomAttribute<BrowsableAttribute>()?.Browsable;
                if (browsable.HasValue && !browsable.Value)
                    continue;

                checkName(method.Name);
                var id = new Dispid
                {
                    Id = _methods.Count,
                    IsMethod = true,
                    IsAsync = IsAsync(method)
                };

                // note we don't support overloaded methods
                _methods[method.Name] = id;
                _getMethods[id.Id] = method;

                //DirectN.Extensions.Utilities.Application.TraceVerbose($"Type '{type.FullName}' method '{method.Name}' id: {_dispidBase + id}");
            }

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            for (var i = 0; i < properties.Length; i++)
            {
                var property = properties[i];

                var browsable = property.GetCustomAttribute<BrowsableAttribute>()?.Browsable;
                if (browsable.HasValue && !browsable.Value)
                    continue;

                var getMethod = property.GetGetMethod();
                if (getMethod == null)
                    continue;

                checkName(property.Name);
                var id = new Dispid { Id = _methods.Count, IsMethod = false };
                _methods[property.Name] = id;
                _getMethods[id.Id] = getMethod;

                //DirectN.Extensions.Utilities.Application.TraceVerbose($"Type '{type.FullName}' get '{property.Name}' id: {_dispidBase + id}");
            }

            void checkName(string name)
            {
                if (name == nameof(ToString)) // don't warn
                    return;

                if (_reservedJavascriptNames.Contains(name, StringComparer.OrdinalIgnoreCase))
                {
                    DirectN.Extensions.Utilities.Application.TraceWarning($"The property or method name '{name}' of '{type.FullName}' type is reserved by JavaScript and will never be used.");
                }
            }
        }

        public MethodInfo? GetMethod(int dispId)
        {
            _getMethods.TryGetValue(dispId, out var method);
            return method;
        }

        public int GetDispId(string name)
        {
            if (!_methods.TryGetValue(name, out var dispId))
                return -1;

            return dispId.Id;
        }

        public bool? IsMethod(string name)
        {
            if (!_methods.TryGetValue(name, out var dispId))
                return false;

            return dispId.IsMethod;
        }

        public bool? IsAsync(string name)
        {
            if (!_methods.TryGetValue(name, out var dispId))
                return false;

            return dispId.IsAsync;
        }

        private struct Dispid
        {
            public int Id;
            public bool IsMethod;
            public bool IsAsync;
        }

        public static bool IsAsync(MethodInfo method) => typeof(Task).IsAssignableFrom(method.ReturnType);
    }

    [GeneratedComClass]
    private partial class Function(DispatchObject obj, MethodInfo method) : IDispatch
    {
#pragma warning disable IDE1006 // Naming Styles
        private const uint WM_COMPLETED = MessageDecoder.WM_APP + 1234;
#pragma warning restore IDE1006 // Naming Styles

        public HRESULT GetTypeInfo(uint iTInfo, uint lcid, out ITypeInfo ppTInfo) => throw new NotSupportedException();
        public HRESULT GetTypeInfoCount(out uint pctinfo)
        {
            pctinfo = 0;
            return DirectN.Constants.S_OK;
        }

        public static unsafe object?[]? BuildArguments(MethodInfo method, in DISPPARAMS parameters)
        {
            var arguments = method.GetParameters();
            if (arguments.Length == 0)
                return null;

            var varArgs = (VARIANT*)parameters.rgvarg;
            var args = new object?[arguments.Length];
            for (var i = 0; i < arguments.Length; i++)
            {
                object? value;
                // note arguments are stored in in reverse order
                var varArgsIndex = parameters.cArgs - i - 1;
                if (varArgsIndex < 0 || varArgsIndex >= parameters.cArgs)
                {
                    value = null;
                }
                else
                {
                    value = Variant.Unwrap(varArgs[varArgsIndex]);
                }

                if (Conversions.TryChangeObjectType(value, arguments[i].ParameterType, out var converted))
                {
                    value = converted;
                }

                args[i] = value;
            }
            return args;
        }

        public static unsafe HRESULT WriteResultAsVARIANT(object? result, nint pVarResult)
        {
            if (result is Variant variant)
            {
                variant.DetachTo(pVarResult);
                return DirectN.Constants.S_OK;
            }

            if (result is VARIANT v)
            {
                *(VARIANT*)pVarResult = v;
                return DirectN.Constants.S_OK;
            }

            if (result is IDictionary dictionary)
            {
                var array = new List<object>(); // cannot use array of DispatchKeyValue directly we want an array of VARIANTs
                foreach (DictionaryEntry kv in dictionary)
                {
                    array.Add(new DispatchKeyValue { Key = kv.Key, Value = kv.Value });
                }
                result = array.ToArray();
            }
            else if (result is Version)
            {
                result = result.ToString();
            }

            using var va = new Variant(result);
            va.DetachTo(pVarResult);
            return DirectN.Constants.S_OK;
        }

        public HRESULT GetIDsOfNames(in Guid riid, PWSTR[] rgszNames, uint cNames, uint lcid, int[] rgDispId)
        {
            if (rgszNames == null || rgszNames.Length == 0 || rgszNames.Length != cNames)
                return DirectN.Constants.E_INVALIDARG;

            // we need to invoke first
            var target = (DispatchObject)method.Invoke(obj, null)!;
            return target.GetIDsOfNames(riid, rgszNames, cNames, lcid, rgDispId);
        }

        public unsafe HRESULT Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr)
        {
            try
            {
                //DirectN.Extensions.Utilities.Application.TraceVerbose($"Function dispIdMember '{dispIdMember}'");
                if (dispIdMember != 0)
                {
                    // we need to invoke first
                    var target = (DispatchObject)method.Invoke(obj, null)!;
                    return target.Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
                }

                var args = BuildArguments(method, pDispParams);
                var result = method.Invoke(obj, args);
                if (result is Task task)
                {
                    // if you are here it's because ContinueOnAsync is false
                    switch (task.Status)
                    {
                        case TaskStatus.RanToCompletion:
                            break;

                        case TaskStatus.Canceled:
                            break;

                        case TaskStatus.Faulted:
                            break;

                        case TaskStatus.Created:
                        case TaskStatus.WaitingForActivation:
                        case TaskStatus.WaitingToRun:
                        case TaskStatus.Running:
                        case TaskStatus.WaitingForChildrenToComplete:
                            // we need to run message loop, on the UI thread, until the task is completed
                            var window = GetWindow();

                            // note this code avoids using reflection on Task<T> to avoid trimming issues with AOT publishing
                            var completed = false;
                            var awaiter = task.GetAwaiter();
                            awaiter.OnCompleted(() =>
                            {
                                completed = true;
                                DirectN.Functions.PostMessageW(window.Handle, WM_COMPLETED, 0, 0);
                            });

                            // note if the window enters a modal loop (like moving it using the caption bar),
                            // the invoke call will not return until the modal loop is exited. Not sure how to avoid this...
                            var app = DirectN.Extensions.Utilities.Application.Current;
                            if (app != null)
                            {
                                while (!completed)
                                {
                                    app.RunMessageLoop(msg => msg.message == WM_COMPLETED);
                                }
                            }
                            break;
                    }

                    result = obj.GetTaskResult(task);
                }

                return WriteResultAsVARIANT(result, pVarResult);
            }
            catch (Exception ex)
            {
                DirectN.Extensions.Utilities.Application.TraceError($" Exception: {ex}");
                if (pExcepInfo != 0)
                {
                    var excepInfo = new EXCEPINFO
                    {
                        bstrSource = new(Marshal.StringToBSTR(GetType().FullName)),
                        scode = ex.HResult,
                        bstrDescription = new(Marshal.StringToBSTR(ex.ToString())),
                    };

                    *(EXCEPINFO*)pExcepInfo = excepInfo;
                }
                return DirectN.Constants.E_FAIL;
            }
        }
    }
}