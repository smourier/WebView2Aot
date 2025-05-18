namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ShowSaveAsUICompletedHandler(Action<HRESULT, COREWEBVIEW2_SAVE_AS_UI_RESULT> handler)
    : ICoreWebView2ShowSaveAsUICompletedHandler
{
    public virtual HRESULT Invoke(HRESULT errorCode, COREWEBVIEW2_SAVE_AS_UI_RESULT result)
    {
        handler(errorCode, result);
        return 0;
    }
}
