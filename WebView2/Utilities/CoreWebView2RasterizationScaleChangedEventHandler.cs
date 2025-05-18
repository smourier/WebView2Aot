namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2RasterizationScaleChangedEventHandler(Action<ICoreWebView2Controller, IUnknown> handler)
    : ICoreWebView2RasterizationScaleChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Controller sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
