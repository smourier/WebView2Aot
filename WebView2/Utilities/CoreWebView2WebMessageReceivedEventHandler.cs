namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2WebMessageReceivedEventHandler(Action<ICoreWebView2, ICoreWebView2WebMessageReceivedEventArgs> handler)
    : ICoreWebView2WebMessageReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2WebMessageReceivedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
