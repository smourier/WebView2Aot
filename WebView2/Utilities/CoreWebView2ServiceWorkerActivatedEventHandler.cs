namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerActivatedEventHandler(Action<ICoreWebView2ServiceWorkerRegistration, ICoreWebView2ServiceWorkerActivatedEventArgs> handler)
    : ICoreWebView2ServiceWorkerActivatedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorkerRegistration sender, ICoreWebView2ServiceWorkerActivatedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
