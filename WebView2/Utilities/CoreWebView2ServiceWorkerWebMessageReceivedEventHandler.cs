namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerWebMessageReceivedEventHandler(Action<ICoreWebView2ServiceWorker, ICoreWebView2WebMessageReceivedEventArgs> handler)
    : ICoreWebView2ServiceWorkerWebMessageReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorker sender, ICoreWebView2WebMessageReceivedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
