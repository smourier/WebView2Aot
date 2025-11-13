namespace WebView2;

[GeneratedComInterface, Guid("2C94DD56-E252-40A1-BA7E-B19417B26A60")]
public partial interface ICoreWebView2PrivatePartial
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddHostObjectHelper([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PrivateHostObjectHelper>))] ICoreWebView2PrivateHostObjectHelper helper);
}
