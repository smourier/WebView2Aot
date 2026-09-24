namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2BasicAuthenticationRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2BasicAuthenticationRequestedEventArgs> handler)
    : ICoreWebView2BasicAuthenticationRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2BasicAuthenticationRequestedEventArgs args)
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
