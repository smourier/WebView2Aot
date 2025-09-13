#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f41f3f8a-bcc3-11eb-8529-0242ac130003")]
public partial interface ICoreWebView2StringCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, out PWSTR value);
}
