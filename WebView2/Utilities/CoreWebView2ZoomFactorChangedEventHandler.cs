namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ZoomFactorChangedEventHandler(Action<ICoreWebView2Controller, IUnknown> handler)
    : ICoreWebView2ZoomFactorChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Controller sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
