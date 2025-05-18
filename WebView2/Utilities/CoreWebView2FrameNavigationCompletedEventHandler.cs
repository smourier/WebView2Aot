namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameNavigationCompletedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2NavigationCompletedEventArgs> handler)
    : ICoreWebView2FrameNavigationCompletedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2NavigationCompletedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
