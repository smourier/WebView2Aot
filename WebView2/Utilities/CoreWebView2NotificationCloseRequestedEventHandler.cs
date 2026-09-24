namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2NotificationCloseRequestedEventHandler(Action<ICoreWebView2Notification, IUnknown> handler)
    : ICoreWebView2NotificationCloseRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Notification sender, IUnknown args)
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
