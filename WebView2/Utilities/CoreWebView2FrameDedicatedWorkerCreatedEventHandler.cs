namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameDedicatedWorkerCreatedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2DedicatedWorkerCreatedEventArgs> handler)
    : ICoreWebView2FrameDedicatedWorkerCreatedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2DedicatedWorkerCreatedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
