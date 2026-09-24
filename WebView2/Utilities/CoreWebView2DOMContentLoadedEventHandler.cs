namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DOMContentLoadedEventHandler(Action<ICoreWebView2, ICoreWebView2DOMContentLoadedEventArgs> handler)
    : ICoreWebView2DOMContentLoadedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2DOMContentLoadedEventArgs args)
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
