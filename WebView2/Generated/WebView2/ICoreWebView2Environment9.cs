#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f06f41bf-4b5a-49d8-b9f6-fa16cd29f274")]
public partial interface ICoreWebView2Environment9 : ICoreWebView2Environment8
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateContextMenuItem(PWSTR Label, IStream iconStream, COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContextMenuItem>))] out ICoreWebView2ContextMenuItem value);
}
