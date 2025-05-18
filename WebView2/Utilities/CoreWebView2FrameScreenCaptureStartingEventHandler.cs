namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameScreenCaptureStartingEventHandler(Action<ICoreWebView2Frame, ICoreWebView2ScreenCaptureStartingEventArgs> handler)
    : ICoreWebView2FrameScreenCaptureStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2ScreenCaptureStartingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
