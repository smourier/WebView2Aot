#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("912b34a7-d10b-49c4-af18-7cb7e604e01a")]
public partial interface ICoreWebView2Interop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddHostObjectToScript(PWSTR name, ref VARIANT @object);
}
