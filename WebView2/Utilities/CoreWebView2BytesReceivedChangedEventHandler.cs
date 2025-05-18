namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2BytesReceivedChangedEventHandler(Action<ICoreWebView2DownloadOperation, IUnknown> handler)
    : ICoreWebView2BytesReceivedChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DownloadOperation sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
