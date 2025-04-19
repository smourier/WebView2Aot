#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("16b1e21a-c503-44f2-84c9-70aba5031283")]
public partial interface ICoreWebView2DOMContentLoadedEventArgs
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NavigationId(ref ulong value);
}
