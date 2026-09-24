namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NavigationStartingEventHandler(Action<ICoreWebView2, ICoreWebView2NavigationStartingEventArgs> handler)
    : ICoreWebView2NavigationStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2NavigationStartingEventArgs args)
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
