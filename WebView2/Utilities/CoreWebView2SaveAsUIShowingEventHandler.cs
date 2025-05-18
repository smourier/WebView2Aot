namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SaveAsUIShowingEventHandler(Action<ICoreWebView2, ICoreWebView2SaveAsUIShowingEventArgs> handler)
    : ICoreWebView2SaveAsUIShowingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2SaveAsUIShowingEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
