namespace ScriptHostObjectWebView2;

[GeneratedComClass]
public partial class WebViewHostObjectHelper : ICoreWebView2PrivateHostObjectHelper, ICoreWebView2PrivateHostObjectHelper2
{
    HRESULT ICoreWebView2PrivateHostObjectHelper.IsMethodMember(
        ref VARIANT @object,
        PWSTR memberName,
        out BOOL value)
    {
        value = false;
        var disp = GetDispatchObject(ref @object);
        if (disp == null)
            return DirectN.Constants.DISP_E_TYPEMISMATCH;

        value = disp.IsMethod(memberName.ToString());
        return DirectN.Constants.S_OK;
    }

    HRESULT ICoreWebView2PrivateHostObjectHelper2.IsAsyncMethod(
        ref VARIANT @object,
        PWSTR methodName,
        int parameterCount,
        out BOOL value)
    {
        value = false;
        var disp = GetDispatchObject(ref @object);
        if (disp == null)
            return DirectN.Constants.DISP_E_TYPEMISMATCH;

        value = disp.IsAsync(methodName.ToString());
        return DirectN.Constants.S_OK;
    }

    HRESULT ICoreWebView2PrivateHostObjectHelper2.SetAsyncMethodContinuation(
        ref VARIANT @object,
        PWSTR methodName,
        int parameterCount,
        ref VARIANT methodResult,
        ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation)
    {
        var disp = GetDispatchObject(ref @object);
        if (disp == null)
            return DirectN.Constants.DISP_E_TYPEMISMATCH;

        if (DirectN.Extensions.Com.ComObject.ComWrappers.GetOrCreateObjectForComInstance(methodResult.Anonymous.Anonymous.Anonymous.pdispVal, CreateObjectFlags.Unwrap) is not DispatchObject.TaskFunction func)
            return DirectN.Constants.DISP_E_TYPEMISMATCH;

        func.Continue((hr, result) => continuation.Invoke(hr, ref result));
        return DirectN.Constants.S_OK;
    }

    protected virtual DispatchObject? GetDispatchObject(ref VARIANT obj)
    {
        if (obj.Anonymous.Anonymous.vt != VARENUM.VT_DISPATCH)
            return null;

        return DirectN.Extensions.Com.ComObject.ComWrappers.GetOrCreateObjectForComInstance(obj.Anonymous.Anonymous.Anonymous.pdispVal, CreateObjectFlags.Unwrap) as DispatchObject;
    }
}
