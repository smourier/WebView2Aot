namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2StateChangedEventHandler(Action<ICoreWebView2DownloadOperation, IUnknown> handler)
    : ICoreWebView2StateChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DownloadOperation sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
