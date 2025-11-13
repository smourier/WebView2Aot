namespace WebView2;

[GeneratedComInterface, Guid("A791A659-3AD9-41C3-9C7E-768FCC233666")]
public partial interface ICoreWebView2PrivateHostObjectHelper2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAsyncMethod(ref VARIANT @object, PWSTR methodName, int parameterCount, out BOOL value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAsyncMethodContinuation(ref VARIANT @object, PWSTR methodName, int parameterCount, ref VARIANT methodResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrivateHostObjectAsyncMethodContinuation>))] ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation);
}