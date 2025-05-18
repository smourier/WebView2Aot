namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CreateCoreWebView2ControllerCompletedHandler(Action<HRESULT, ICoreWebView2Controller> handler)
    : ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, ICoreWebView2Controller result)
    {
        handler(errorCode, result);
        return 0;
    }
}
