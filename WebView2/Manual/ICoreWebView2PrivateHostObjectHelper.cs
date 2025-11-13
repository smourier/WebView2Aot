namespace WebView2;

[GeneratedComInterface, Guid("1656D586-E714-4092-9C76-014647940EFF")]
public partial interface ICoreWebView2PrivateHostObjectHelper
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMethodMember(ref VARIANT @object, PWSTR memberName, out BOOL value);
}
