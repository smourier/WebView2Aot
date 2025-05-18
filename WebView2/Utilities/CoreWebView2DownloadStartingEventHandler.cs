namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DownloadStartingEventHandler(Action<ICoreWebView2, ICoreWebView2DownloadStartingEventArgs> handler)
    : ICoreWebView2DownloadStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2DownloadStartingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
