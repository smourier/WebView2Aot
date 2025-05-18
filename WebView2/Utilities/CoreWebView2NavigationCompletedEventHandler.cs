namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NavigationCompletedEventHandler(Action<ICoreWebView2, ICoreWebView2NavigationCompletedEventArgs> handler)
    : ICoreWebView2NavigationCompletedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2NavigationCompletedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
