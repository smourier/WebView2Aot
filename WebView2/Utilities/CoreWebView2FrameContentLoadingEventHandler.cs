namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameContentLoadingEventHandler(Action<ICoreWebView2Frame, ICoreWebView2ContentLoadingEventArgs> handler)
    : ICoreWebView2FrameContentLoadingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2ContentLoadingEventArgs args)
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
