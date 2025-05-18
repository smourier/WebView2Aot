namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CapturePreviewCompletedHandler(Action<HRESULT> handler)
    : ICoreWebView2CapturePreviewCompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode)
    {
        handler(errorCode);
        return 0;
    }
}
