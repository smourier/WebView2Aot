namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NavigationStartingEventHandler(Action<ICoreWebView2, ICoreWebView2NavigationStartingEventArgs> handler)
    : ICoreWebView2NavigationStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2NavigationStartingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
