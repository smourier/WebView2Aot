namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CreateCoreWebView2ControllerCompletedHandler(Action<HRESULT, ICoreWebView2Controller> handler)
    : ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
{
    public HRESULT Invoke(HRESULT result, ICoreWebView2Controller controller)
    {
        handler(result, controller);
        return 0;
    }
}
