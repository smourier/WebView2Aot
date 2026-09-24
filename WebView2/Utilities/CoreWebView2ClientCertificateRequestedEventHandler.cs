namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ClientCertificateRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2ClientCertificateRequestedEventArgs> handler)
    : ICoreWebView2ClientCertificateRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ClientCertificateRequestedEventArgs args)
    {
        try
        {
            handler(sender, args);
        }
        finally
        {
            DirectN.Extensions.Com.ComObject.FinalRelease((object)sender as System.Runtime.InteropServices.Marshalling.ComObject);
        }

        return 0;
    }
}
