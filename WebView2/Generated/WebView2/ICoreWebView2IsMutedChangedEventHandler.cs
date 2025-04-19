#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("57d90347-cd0e-4952-a4a2-7483a2756f08")]
public partial interface ICoreWebView2IsMutedChangedEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, IUnknown args);
}
