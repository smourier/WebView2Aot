namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DedicatedWorkerCreatedEventHandler(Action<ICoreWebView2, ICoreWebView2DedicatedWorkerCreatedEventArgs> handler)
    : ICoreWebView2DedicatedWorkerCreatedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2DedicatedWorkerCreatedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
