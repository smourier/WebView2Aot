namespace WebView2;

[GeneratedComInterface, Guid("FF1BBF9A-37E0-45F8-88C5-9DF6B5DD5F4C")]
public partial interface ICoreWebView2PrivateHostObjectAsyncMethodContinuation
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalAs(UnmanagedType.Error)] HRESULT errorCode, ref VARIANT result);
}
