namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DedicatedWorkerDestroyingEventHandler(Action<ICoreWebView2DedicatedWorker, IUnknown> handler)
    : ICoreWebView2DedicatedWorkerDestroyingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DedicatedWorker sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
