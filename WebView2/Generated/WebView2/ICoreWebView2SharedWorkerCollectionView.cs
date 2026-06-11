#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("f8842b09-0108-5575-a965-3d76fd267050")]
public partial interface ICoreWebView2SharedWorkerCollectionView
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SharedWorker>))] out ICoreWebView2SharedWorker value);
}
