namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NotificationReceivedEventHandler(Action<ICoreWebView2, ICoreWebView2NotificationReceivedEventArgs> handler)
    : ICoreWebView2NotificationReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2NotificationReceivedEventArgs args)
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
