namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2EstimatedEndTimeChangedEventHandler(Action<ICoreWebView2DownloadOperation, IUnknown> handler)
    : ICoreWebView2EstimatedEndTimeChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DownloadOperation sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
