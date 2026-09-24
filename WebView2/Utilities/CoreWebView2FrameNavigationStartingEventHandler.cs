namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameNavigationStartingEventHandler(Action<ICoreWebView2Frame, ICoreWebView2NavigationStartingEventArgs> handler)
    : ICoreWebView2FrameNavigationStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2NavigationStartingEventArgs args)
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
