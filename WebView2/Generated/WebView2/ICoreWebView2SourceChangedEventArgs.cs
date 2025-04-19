#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("31e0e545-1dba-4266-8914-f63848a1f7d7")]
public partial interface ICoreWebView2SourceChangedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsNewDocument(ref BOOL value);
}
