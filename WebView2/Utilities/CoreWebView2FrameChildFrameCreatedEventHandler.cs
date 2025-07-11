namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameChildFrameCreatedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2FrameCreatedEventArgs> handler)
    : ICoreWebView2FrameChildFrameCreatedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2FrameCreatedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
