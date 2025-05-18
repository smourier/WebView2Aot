namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NewWindowRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2NewWindowRequestedEventArgs> handler)
    : ICoreWebView2NewWindowRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2NewWindowRequestedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
