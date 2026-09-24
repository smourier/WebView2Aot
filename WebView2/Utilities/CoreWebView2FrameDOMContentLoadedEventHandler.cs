namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameDOMContentLoadedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2DOMContentLoadedEventArgs> handler)
    : ICoreWebView2FrameDOMContentLoadedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2DOMContentLoadedEventArgs args)
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
