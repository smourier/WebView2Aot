namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameScreenCaptureStartingEventHandler(Action<ICoreWebView2Frame, ICoreWebView2ScreenCaptureStartingEventArgs> handler)
    : ICoreWebView2FrameScreenCaptureStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2ScreenCaptureStartingEventArgs args)
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
