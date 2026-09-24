namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerDestroyingEventHandler(Action<ICoreWebView2ServiceWorker, IUnknown> handler)
    : ICoreWebView2ServiceWorkerDestroyingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorker sender, IUnknown args)
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
