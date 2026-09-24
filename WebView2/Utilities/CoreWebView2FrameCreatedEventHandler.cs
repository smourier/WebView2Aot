namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameCreatedEventHandler(Action<ICoreWebView2, ICoreWebView2FrameCreatedEventArgs> handler)
    : ICoreWebView2FrameCreatedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2FrameCreatedEventArgs args)
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
