namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SharedWorkerDestroyingEventHandler(Action<ICoreWebView2SharedWorker, IUnknown> handler)
    : ICoreWebView2SharedWorkerDestroyingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2SharedWorker sender, IUnknown args)
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
