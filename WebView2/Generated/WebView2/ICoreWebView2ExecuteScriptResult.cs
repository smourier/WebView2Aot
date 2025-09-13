#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0ce15963-3698-4df7-9399-71ed6cdd8c9f")]
public partial interface ICoreWebView2ExecuteScriptResult
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Succeeded(ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ResultAsJson(out PWSTR jsonResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryGetResultAsString(out PWSTR stringResult, ref BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Exception([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ScriptException>))] out ICoreWebView2ScriptException exception);
}
