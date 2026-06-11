namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SharedWorkerDestroyingEventHandler(Action<ICoreWebView2SharedWorker, IUnknown> handler)
    : ICoreWebView2SharedWorkerDestroyingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2SharedWorker sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
