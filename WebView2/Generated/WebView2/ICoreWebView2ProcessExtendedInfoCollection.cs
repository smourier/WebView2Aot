#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("32efa696-407a-11ee-be56-0242ac120002")]
public partial interface ICoreWebView2ProcessExtendedInfoCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAtIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessExtendedInfo>))] out ICoreWebView2ProcessExtendedInfo value);
}
