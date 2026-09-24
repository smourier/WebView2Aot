namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2MoveFocusRequestedEventHandler(Action<ICoreWebView2Controller, ICoreWebView2MoveFocusRequestedEventArgs> handler)
    : ICoreWebView2MoveFocusRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Controller sender, ICoreWebView2MoveFocusRequestedEventArgs args)
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
