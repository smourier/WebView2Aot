namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ClientCertificateRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2ClientCertificateRequestedEventArgs> handler)
    : ICoreWebView2ClientCertificateRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ClientCertificateRequestedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
