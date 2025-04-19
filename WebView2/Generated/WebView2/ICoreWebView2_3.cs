#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a0d6df20-3b92-416d-aa0c-437a9c727857")]
public partial interface ICoreWebView2_3 : ICoreWebView2_2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TrySuspend([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2TrySuspendCompletedHandler>))] ICoreWebView2TrySuspendCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsSuspended(ref BOOL isSuspended);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVirtualHostNameToFolderMapping(PWSTR hostName, PWSTR folderPath, COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearVirtualHostNameToFolderMapping(PWSTR hostName);
}
