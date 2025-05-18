namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ScreenCaptureStartingEventHandler(Action<ICoreWebView2, ICoreWebView2ScreenCaptureStartingEventArgs> handler)
    : ICoreWebView2ScreenCaptureStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ScreenCaptureStartingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
