namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ContextMenuRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2ContextMenuRequestedEventArgs> handler)
    : ICoreWebView2ContextMenuRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ContextMenuRequestedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
