namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerDestroyingEventHandler(Action<ICoreWebView2ServiceWorker, IUnknown> handler)
    : ICoreWebView2ServiceWorkerDestroyingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorker sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
