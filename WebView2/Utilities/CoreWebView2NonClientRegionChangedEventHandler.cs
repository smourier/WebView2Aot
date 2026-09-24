namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NonClientRegionChangedEventHandler(Action<ICoreWebView2CompositionController, ICoreWebView2NonClientRegionChangedEventArgs> handler)
    : ICoreWebView2NonClientRegionChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2CompositionController sender, ICoreWebView2NonClientRegionChangedEventArgs args)
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
