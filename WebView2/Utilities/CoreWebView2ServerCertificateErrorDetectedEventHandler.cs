namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServerCertificateErrorDetectedEventHandler(Action<ICoreWebView2, ICoreWebView2ServerCertificateErrorDetectedEventArgs> handler)
    : ICoreWebView2ServerCertificateErrorDetectedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ServerCertificateErrorDetectedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
