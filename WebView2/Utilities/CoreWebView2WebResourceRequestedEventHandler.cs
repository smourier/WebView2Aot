namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2WebResourceRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2WebResourceRequestedEventArgs> handler)
    : ICoreWebView2WebResourceRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2WebResourceRequestedEventArgs args)
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
