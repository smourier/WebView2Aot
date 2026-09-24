namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerWebMessageReceivedEventHandler(Action<ICoreWebView2ServiceWorker, ICoreWebView2WebMessageReceivedEventArgs> handler)
    : ICoreWebView2ServiceWorkerWebMessageReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorker sender, ICoreWebView2WebMessageReceivedEventArgs args)
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
