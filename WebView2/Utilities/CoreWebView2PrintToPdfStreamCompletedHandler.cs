namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2PrintToPdfStreamCompletedHandler(Action<HRESULT, IStream> handler)
    : ICoreWebView2PrintToPdfStreamCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, IStream result)
    {
        handler(errorCode, result);
        return 0;
    }
}
