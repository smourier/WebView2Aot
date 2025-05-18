namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SourceChangedEventHandler(Action<ICoreWebView2, ICoreWebView2SourceChangedEventArgs> handler)
    : ICoreWebView2SourceChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2SourceChangedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
