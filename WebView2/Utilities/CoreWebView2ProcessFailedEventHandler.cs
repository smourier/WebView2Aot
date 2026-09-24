namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProcessFailedEventHandler(Action<ICoreWebView2, ICoreWebView2ProcessFailedEventArgs> handler)
    : ICoreWebView2ProcessFailedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ProcessFailedEventArgs args)
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
