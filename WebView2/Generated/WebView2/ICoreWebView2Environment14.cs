#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a5e9fad9-c875-59da-9bd7-473aa5ca1cef")]
public partial interface ICoreWebView2Environment14 : ICoreWebView2Environment13
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateWebFileSystemFileHandle(PWSTR path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FileSystemHandle>))] out ICoreWebView2FileSystemHandle value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateWebFileSystemDirectoryHandle(PWSTR path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FileSystemHandle>))] out ICoreWebView2FileSystemHandle value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObjectCollection(uint length, out IUnknown items, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ObjectCollection>))] out ICoreWebView2ObjectCollection objectCollection);
}
