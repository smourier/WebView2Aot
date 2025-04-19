#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("508f0db5-90c4-5872-90a7-267a91377502")]
public partial interface ICoreWebView2_23 : ICoreWebView2_22
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostWebMessageAsJsonWithAdditionalObjects(PWSTR webMessageAsJson, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ObjectCollectionView>))] ICoreWebView2ObjectCollectionView additionalObjects);
}
