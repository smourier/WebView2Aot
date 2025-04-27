namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CursorChangedEventHandler(Action<ICoreWebView2CompositionController, IUnknown> handler)
    : ICoreWebView2CursorChangedEventHandler
{
    public HRESULT Invoke(ICoreWebView2CompositionController sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
