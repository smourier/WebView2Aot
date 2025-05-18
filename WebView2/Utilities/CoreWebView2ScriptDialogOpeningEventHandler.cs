namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ScriptDialogOpeningEventHandler(Action<ICoreWebView2, ICoreWebView2ScriptDialogOpeningEventArgs> handler)
    : ICoreWebView2ScriptDialogOpeningEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ScriptDialogOpeningEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
