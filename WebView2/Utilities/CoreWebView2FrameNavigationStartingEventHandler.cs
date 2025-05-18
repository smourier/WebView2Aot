namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameNavigationStartingEventHandler(Action<ICoreWebView2Frame, ICoreWebView2NavigationStartingEventArgs> handler)
    : ICoreWebView2FrameNavigationStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2NavigationStartingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
