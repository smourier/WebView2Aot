namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FocusChangedEventHandler(Action<ICoreWebView2Controller, IUnknown> handler)
    : ICoreWebView2FocusChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Controller sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
