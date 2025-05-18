namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameDOMContentLoadedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2DOMContentLoadedEventArgs> handler)
    : ICoreWebView2FrameDOMContentLoadedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2DOMContentLoadedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
