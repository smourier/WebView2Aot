namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2GetFaviconCompletedHandler(Action<HRESULT, IStream> handler)
    : ICoreWebView2GetFaviconCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, IStream result)
    {
        handler(errorCode, result);
        return 0;
    }
}
