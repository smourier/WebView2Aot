namespace ScriptHostObjectWebView2.Utilities;

// A generic base host object for the WebView2 control must implement IDispatch
// when we have say, this in javascript:
//
//         var options = JSON.parse(chrome.webview.hostObjects.dotnet.getInfo());
//
// 'dotnet' corresponds to this instance, and the WebView2 runtime will
//
// 1) call "editorControl" asking for a "getOptions" *property* wich should be an object
// 2) call this returned object's to do the function call (with 0 or more parameters). so only Invoke(0) should be called on this
//
// that's why we have two implementations of IDispatch here
[GeneratedComClass]
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
public partial class DispatchObject : IDispatch
{
    private static readonly ConcurrentDictionary<Type, DispatchType> _cache = new();
    private const int _dispidBase = 1000;

    protected virtual object? GetTaskResult(Task task) => null;

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

            if (!_cache.TryGetValue(type, out var dispatchType))
            {
                dispatchType = new DispatchType(type);
                _cache[type] = dispatchType;
            }

            var dispId = dispatchType.GetDispId(name);
            rgDispId[i] = dispId < 0 ? -1 : dispId + _dispidBase;
        }

        if (rgDispId.Any(id => id == -1))
        {
            const int DISP_E_UNKNOWNNAME = unchecked((int)0x80020006);
            return DISP_E_UNKNOWNNAME;
        }
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
                const int DISP_E_MEMBERNOTFOUND = unchecked((int)0x80020003);
                return DISP_E_MEMBERNOTFOUND;
            }

            var func = new Function(this, method);
            var unk = DirectN.Extensions.Com.ComObject.GetOrCreateComInstance(func);
            using var v = new Variant(unk, VARENUM.VT_UNKNOWN);
            var detached = v.Detach();
            *(VARIANT*)pVarResult = detached;
            return DirectN.Constants.S_OK;
        }
        catch (Exception ex)
        {
            if (pExcepInfo != 0)
            {
                var excepInfo = new EXCEPINFO
                {
                    scode = unchecked((int)DirectN.Constants.E_FAIL),
                    bstrDescription = new Bstr(ex.GetAllMessages()),
                };

                *(EXCEPINFO*)pExcepInfo = excepInfo;
            }
            return DirectN.Constants.E_FAIL;
        }
    }

    HRESULT IDispatch.GetTypeInfo(uint iTInfo, uint lcid, out ITypeInfo ppTInfo) => throw new NotImplementedException();
    HRESULT IDispatch.GetTypeInfoCount(out uint pctinfo)
    {
        pctinfo = 0;
        return DirectN.Constants.S_OK;
    }

    private sealed class DispatchType
    {
        private readonly Dictionary<string, int> _methodsIndices;
        private readonly MethodInfo[] _methods;

        public DispatchType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type type)
        {
            _methodsIndices = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            _methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            for (var i = 0; i < _methods.Length; i++)
            {
                var method = _methods[i];
                _methodsIndices[method.Name] = i; // note we don't support overloaded methods
            }
        }

        public MethodInfo? GetMethod(int dispId)
        {
            if (dispId < 0 || dispId >= _methods.Length)
                return null;

            return _methods[dispId];
        }

        public int GetDispId(string name)
        {
            if (!_methodsIndices.TryGetValue(name, out var dispId))
                return -1;

            return dispId;
        }
    }

    [GeneratedComClass]
    private partial class Function(DispatchObject obj, MethodInfo method) : IDispatch
    {
        private const uint WM_COMPLETED = MessageDecoder.WM_APP + 1234;
        private static readonly SingleThreadTaskScheduler _scheduler = new(configure =>
        {
            configure.SetApartmentState(System.Threading.ApartmentState.STA);
            return true;
        });

        public HRESULT GetIDsOfNames(in Guid riid, PWSTR[] rgszNames, uint cNames, uint lcid, int[] rgDispId) => throw new NotImplementedException();
        public HRESULT GetTypeInfo(uint iTInfo, uint lcid, out ITypeInfo ppTInfo) => throw new NotImplementedException();
        public HRESULT GetTypeInfoCount(out uint pctinfo)
        {
            pctinfo = 0;
            return DirectN.Constants.S_OK;
        }

        private static Window GetWindow()
        {
            var windows = Application.GetApplication(Environment.CurrentManagedThreadId)?.Windows;
            if (windows == null || windows.Count == 0)
                throw new InvalidAsynchronousStateException();

            var window = windows.FirstOrDefault(w => w.TaskScheduler != null && !w.IsBackground) ?? windows.FirstOrDefault(w => w.TaskScheduler != null);
            return window == null ? throw new InvalidAsynchronousStateException() : window;
        }

        private unsafe object?[]? BuildArguments(in DISPPARAMS parameters)
        {
            var arguments = method.GetParameters();
            if (arguments.Length != parameters.cArgs)
                throw new Exception($"Expected {arguments.Length} arguments for '{obj.GetType().FullName}::{method.Name}' method, but got {parameters.cArgs}.");

            if (arguments.Length == 0)
                return null;

            var varArgs = (VARIANT*)parameters.rgvarg;
            var args = new object?[arguments.Length];
            for (var i = 0; i < parameters.cArgs; i++)
            {
                // note arguments are stored in in reverse order
                var value = Variant.Unwrap(varArgs[parameters.cArgs - i - 1]);
                args[i] = value;
            }
            return args;
        }

        public unsafe HRESULT Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr)
        {
            try
            {
                if (dispIdMember != 0)
                {
                    const int DISP_E_MEMBERNOTFOUND = unchecked((int)0x80020003);
                    throw new COMException() { HResult = DISP_E_MEMBERNOTFOUND };
                }

                var args = BuildArguments(pDispParams);
                var result = method.Invoke(obj, args);
                if (result is Task task)
                {
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
                    while (!completed)
                    {
                        Application.Current?.RunMessageLoop(msg => msg.message == WM_COMPLETED);
                    }

                    result = obj.GetTaskResult(task);
                }

                using var v = new Variant(result);
                var detached = v.Detach();
                *(VARIANT*)pVarResult = detached;
                return DirectN.Constants.S_OK;
            }
            catch (Exception ex)
            {
                if (pExcepInfo != 0)
                {
                    var excepInfo = new EXCEPINFO
                    {
                        scode = unchecked((int)DirectN.Constants.E_FAIL),
                        bstrDescription = new Bstr(ex.GetAllMessages()),
                    };

                    *(EXCEPINFO*)pExcepInfo = excepInfo;
                }
                return DirectN.Constants.E_FAIL;
            }
        }
    }
}