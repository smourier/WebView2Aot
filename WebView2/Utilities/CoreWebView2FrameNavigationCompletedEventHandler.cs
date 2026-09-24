namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameNavigationCompletedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2NavigationCompletedEventArgs> handler)
    : ICoreWebView2FrameNavigationCompletedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2NavigationCompletedEventArgs args)
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
