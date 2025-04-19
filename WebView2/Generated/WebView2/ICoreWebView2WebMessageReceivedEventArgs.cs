#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("0f99a40c-e962-4207-9e92-e3d542eff849")]
public partial interface ICoreWebView2WebMessageReceivedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Source(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WebMessageAsJson(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryGetWebMessageAsString(ref PWSTR value);
}
