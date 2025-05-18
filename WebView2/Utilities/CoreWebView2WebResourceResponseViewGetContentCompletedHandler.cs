namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2WebResourceResponseViewGetContentCompletedHandler(Action<HRESULT, IStream> handler)
    : ICoreWebView2WebResourceResponseViewGetContentCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, IStream result)
    {
        handler(errorCode, result);
        return 0;
    }
}
