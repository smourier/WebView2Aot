namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NewWindowRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2NewWindowRequestedEventArgs> handler)
    : ICoreWebView2NewWindowRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2NewWindowRequestedEventArgs args)
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
