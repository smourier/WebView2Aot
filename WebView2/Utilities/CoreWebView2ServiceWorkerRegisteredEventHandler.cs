namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerRegisteredEventHandler(Action<ICoreWebView2ServiceWorkerManager, ICoreWebView2ServiceWorkerRegisteredEventArgs> handler)
    : ICoreWebView2ServiceWorkerRegisteredEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorkerManager sender, ICoreWebView2ServiceWorkerRegisteredEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
