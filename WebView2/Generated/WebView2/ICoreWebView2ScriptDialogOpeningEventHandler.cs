#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("ef381bf9-afa8-4e37-91c4-8ac48524bdfb")]
public partial interface ICoreWebView2ScriptDialogOpeningEventHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2>))] ICoreWebView2 sender, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ScriptDialogOpeningEventArgs>))] ICoreWebView2ScriptDialogOpeningEventArgs args);
}
