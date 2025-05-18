namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2WebResourceResponseReceivedEventHandler(Action<ICoreWebView2, ICoreWebView2WebResourceResponseReceivedEventArgs> handler)
    : ICoreWebView2WebResourceResponseReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2WebResourceResponseReceivedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
