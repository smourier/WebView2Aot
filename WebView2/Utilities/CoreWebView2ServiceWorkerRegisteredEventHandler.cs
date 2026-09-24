namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerRegisteredEventHandler(Action<ICoreWebView2ServiceWorkerManager, ICoreWebView2ServiceWorkerRegisteredEventArgs> handler)
    : ICoreWebView2ServiceWorkerRegisteredEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorkerManager sender, ICoreWebView2ServiceWorkerRegisteredEventArgs args)
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
